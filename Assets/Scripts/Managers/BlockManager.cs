using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public class BlockManager
    {
        private Dictionary<Vector3Int, BaseBlock> blocks;

        public BlockManager()
        {
            blocks = new Dictionary<Vector3Int, BaseBlock>();
        }

        public void AddBlock(Vector3Int localPosition, BaseBlock block)
        {
            if (!blocks.ContainsKey(localPosition))
            {
                blocks[localPosition] = block;
                block.OnGenerate();
            }
        }

        public void RemoveBlock(Vector3Int localPosition)
        {
            if (blocks.ContainsKey(localPosition))
            {
                var block = blocks[localPosition];
                block.OnDestroy();
                blocks.Remove(localPosition);
            }
        }

        public BaseBlock GetBlock(Vector3Int localPosition)
        {
            blocks.TryGetValue(localPosition, out var block);
            return block;
        }
    }
}
