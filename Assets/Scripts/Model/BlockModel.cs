using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    
    public interface IBlockModel : IModel
    {
        void AddBlock(Vector3Int position, BaseBlock block);
        void RemoveBlock(Vector3Int position);
        BaseBlock GetBlock(Vector3Int position);
    }
    
    public class BlockModel : AbstractModel, IBlockModel
    {
        private Dictionary<Vector3Int, BaseBlock> blocks;

        protected override void OnInit()
        {
            blocks = new Dictionary<Vector3Int, BaseBlock>();
        }

        public void AddBlock(Vector3Int position, BaseBlock block)
        {
            if (!blocks.ContainsKey(position))
            {
                blocks[position] = block;
                block.OnGenerate();
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


