using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public class Chunk
    {
        public Vector3Int Position { get; private set; }
        public BlockManager BlockManager { get; private set; }

        private int chunkSize = 16;

        public Chunk(Vector3Int position)
        {
            Position = position;
            BlockManager = new BlockManager();
        }
        
    }
}

