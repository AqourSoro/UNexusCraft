using System;
using UnityEngine;
using QFramework;

namespace NexusCraft
{
    public static class BlockFactory
    {
        public static BaseBlock CreateBlock(BlockType type, Vector3Int position)
        {
            BaseBlock block = type switch
            {
                BlockType.Dirt => new DirtBlock(position),
                BlockType.Water => new WaterBlock(position),
                BlockType.Glass => new GlassBlock(position),
                _ => throw new ArgumentException("Unknown block type")
            };

            return block;
        }
    }
}

