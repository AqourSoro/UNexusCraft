using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public class BlockModel : AbstractModel, IBlockModel
    {
    

        private ChunkManager chunkManager;

        protected override void OnInit()
        {
            chunkManager = new ChunkManager();
        }

        public void AddBlock(Vector3Int position, BaseBlock block)
        {
            chunkManager.AddBlock(position, block);
        }

        public void RemoveBlock(Vector3Int position)
        {
            chunkManager.RemoveBlock(position);
        }

        public BaseBlock GetBlock(Vector3Int position)
        {
            return chunkManager.GetBlock(position);
        }
    }
}


