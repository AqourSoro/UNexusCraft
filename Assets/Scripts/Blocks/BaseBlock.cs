using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public abstract class BaseBlock
    {
        public Vector3Int Position { get; private set; }
        public BlockType Type { get; private set; }

        protected BaseBlock(Vector3Int position, BlockType type)
        {
            Position = position;
            Type = type;
        }

        public abstract void OnGenerate();

        public abstract void OnDestroy();

    }

    public enum BlockType
    {
        Dirt,
        Stone,
        Water,
        Air,
        Sand,
        Glass
    }

}
