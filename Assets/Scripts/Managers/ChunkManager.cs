using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public class ChunkManager : IController
    {
        private Dictionary<Vector3Int, Chunk> chunks;
        private int chunkSize = 16;

        public ChunkManager()
        {
            chunks = new Dictionary<Vector3Int, Chunk>();
        }

        public Chunk GetOrCreateChunk(Vector3Int chunkPosition)
        {
            if (!chunks.ContainsKey(chunkPosition))
            {
                chunks[chunkPosition] = new Chunk(chunkPosition);
            }
            return chunks[chunkPosition];
        }

        public void AddBlock(Vector3Int position, BaseBlock block)
        {
            var chunkPosition = GetChunkPosition(position);
            var localPosition = GetLocalPosition(position);
            var chunk = GetOrCreateChunk(chunkPosition);
            chunk.AddBlock(localPosition, block);
        }

        public void RemoveBlock(Vector3Int position)
        {
            var chunkPosition = GetChunkPosition(position);
            var localPosition = GetLocalPosition(position);
            if (chunks.ContainsKey(chunkPosition))
            {
                var chunk = chunks[chunkPosition];
                chunk.RemoveBlock(localPosition);
            }
        }

        public BaseBlock GetBlock(Vector3Int position)
        {
            var chunkPosition = GetChunkPosition(position);
            var localPosition = GetLocalPosition(position);
            if (chunks.ContainsKey(chunkPosition))
            {
                return chunks[chunkPosition].GetBlock(localPosition);
            }
            return null;
        }

        private Vector3Int GetChunkPosition(Vector3Int position)
        {
            return new Vector3Int(
                Mathf.FloorToInt(position.x / chunkSize),
                Mathf.FloorToInt(position.y / chunkSize),
                Mathf.FloorToInt(position.z / chunkSize)
            );
        }

        private Vector3Int GetLocalPosition(Vector3Int position)
        {
            return new Vector3Int(
                position.x % chunkSize,
                position.y % chunkSize,
                position.z % chunkSize
            );
        }
        

        public IArchitecture GetArchitecture()
        {
            return UNexusCraft.Interface;
        }
    }
}
