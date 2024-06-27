using System.Collections;
using System.Collections.Generic;
using QFramework;
using UnityEngine;

namespace NexusCraft
{
    public class BlockManager :IController
    {
        private void TestChunkManager()
        {
            var blockModel = this.GetModel<IBlockModel>();

            // 示例：在位置(0, 0, 0)生成一个泥土方块
            var block = BlockFactory.CreateBlock(BlockType.Dirt, new Vector3Int(0, 0, 0));
            block.OnGenerate();

            // 示例：在位置(1, 0, 0)生成一个水方块
            var waterBlock = BlockFactory.CreateBlock(BlockType.Water, new Vector3Int(1, 0, 0));
            waterBlock.OnGenerate();

            // 示例：在位置(2, 0, 0)生成一个玻璃方块
            var glassBlock = BlockFactory.CreateBlock(BlockType.Glass, new Vector3Int(2, 0, 0));
            glassBlock.OnGenerate();

            // 示例：销毁位置(0, 0, 0)的方块
            var dirtBlock = blockModel.GetBlock(new Vector3Int(0, 0, 0));
            if (dirtBlock != null)
            {
                blockModel.RemoveBlock(new Vector3Int(0, 0, 0));
                dirtBlock.OnDestroy();
            }

            // 示例：销毁位置(1, 0, 0)的方块
            var waterBlockInstance = blockModel.GetBlock(new Vector3Int(1, 0, 0));
            if (waterBlockInstance != null)
            {
                blockModel.RemoveBlock(new Vector3Int(1, 0, 0));
                waterBlockInstance.OnDestroy();
            }

            // 示例：销毁位置(2, 0, 0)的方块
            var glassBlockInstance = blockModel.GetBlock(new Vector3Int(2, 0, 0));
            if (glassBlockInstance != null)
            {
                blockModel.RemoveBlock(new Vector3Int(2, 0, 0));
                glassBlockInstance.OnDestroy();
            }
        }

        public IArchitecture GetArchitecture()
        {
            return UNexusCraft.Interface;
        }
    }
}
