using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public class Chunk 
    {
        public Vector3Int Position { get; private set; }
        private Dictionary<Vector3Int, BaseBlock> blocks;

        private int chunkSize = 16;

        public Chunk(Vector3Int position)
        {
            Position = position;
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
            if (!blocks.ContainsKey(localPosition))
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

        public Vector3Int GetLocalPosition(Vector3Int position)
        {
            return new Vector3Int
            (
                position.x % chunkSize,
                position.y % chunkSize,
                position.z % chunkSize
            );
        }

    }
}

