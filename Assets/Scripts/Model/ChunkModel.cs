using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public interface IChunkModel : IModel
    {
        void AddChunk(Vector3Int position, Chunk chunk);
        void RemoveChunk(Vector3Int position);
        Chunk GetChunk(Vector3Int position);
    }

    public class ChunkModel : AbstractModel, IChunkModel
    {

        private Dictionary<Vector3Int, Chunk> chunks;

        protected override void OnInit()
        {
            chunks = new Dictionary<Vector3Int, Chunk>();
        }

        public void AddChunk(Vector3Int position, Chunk chunk)
        {
            if (!chunks.ContainsKey(position))
            {
                chunks[position] = chunk;
            }
        }

        public void RemoveChunk(Vector3Int position)
        {
            if (chunks.ContainsKey(position))
            {
                chunks.Remove(position);
            }
        }

        public Chunk GetChunk(Vector3Int position)
        {
            chunks.TryGetValue(position, out var chunk);
            return chunk;
        }
    }
    
}
