using System;
using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public class ChunkManager : MonoBehaviour, IController
    {
        private IChunkModel chunkModel;

        private bool isTested;
        
        void Start()
        {
            isTested = false;
        }

        private void Update()
        {
            if (!isTested && this.GetModel<IPrefabModel>().IsLoaded)
            {
                TestChunkManager();
                isTested = true;
            }
        }

        void TestChunkManager()
        {
            chunkModel = this.GetModel<IChunkModel>();

            // 示例：在位置(0, 0, 0)生成一个区块
            var chunk = new Chunk(new Vector3Int(0, 0, 0));
            chunkModel.AddChunk(chunk.Position, chunk);

            // 示例：在区块内的本地位置(1, 0, 1)生成一个泥土方块
            var block = BlockFactory.CreateBlock(BlockType.Dirt, new Vector3Int(1, 0, 1));
            chunk.BlockManager.AddBlock(new Vector3Int(1, 0, 1), block);

            // 获取并移除方块的示例
            var retrievedBlock = chunk.BlockManager.GetBlock(new Vector3Int(1, 0, 1));
            if (retrievedBlock != null)
            {
                chunk.BlockManager.RemoveBlock(new Vector3Int(1, 0, 1));
            }

            // 获取并移除区块的示例
            var retrievedChunk = chunkModel.GetChunk(new Vector3Int(0, 0, 0));
            if (retrievedChunk != null)
            {
                chunkModel.RemoveChunk(new Vector3Int(0, 0, 0));
            }
            
            Debug.Log("Test Done!");
            
        }
        
        public IArchitecture GetArchitecture()
        {
            return UNexusCraft.Interface;
        }
    }
}
