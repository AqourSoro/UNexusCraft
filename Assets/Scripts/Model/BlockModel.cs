using System.Collections;
using System.Collections.Generic;
using QFramework;
using Unity.VisualScripting;
using UnityEngine;

namespace NexusCraft
{
    
    public interface IBlockModel : IModel
    {
        void AddBlock(Vector3Int position, BaseBlock block);
        void RemoveBlock(Vector3Int position);
        BaseBlock GetBlock(Vector3Int position);
    }
    
    public class BlockModel : AbstractModel, IBlockModel, ICanGetModel
    {
        private Dictionary<Vector3Int, BaseBlock> blocks;

        private IPrefabModel prefabModel;
        
        protected override void OnInit()
        {
            blocks = new Dictionary<Vector3Int, BaseBlock>();
            prefabModel = this.GetModel<IPrefabModel>();
        }

        public void AddBlock(Vector3Int position, BaseBlock block)
        {
            if (!blocks.ContainsKey(position))
            {
                blocks[position] = block;

                if (prefabModel.IsLoaded)
                {
                    // var prefab = prefabModel.GetPrefab(block.Type.ToString());
                    var prefab = prefabModel.GetPrefab("TestCube");
                    block.OnGenerate(prefab);
                }
                else
                {
                    Debug.LogWarning("Prefabs are not loaded yet.");
                }
            }
        }

        public void RemoveBlock(Vector3Int position)
        {
            if (blocks.ContainsKey(position))
            {
                blocks[position].OnDestroy();
                blocks.Remove(position);
            }
        }

        public BaseBlock GetBlock(Vector3Int position)
        {
            blocks.TryGetValue(position, out var block);
            return block;
        }
    }
}


