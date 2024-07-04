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

        public virtual void OnGenerate(GameObject prefab)
        {
            if (prefab != null)
            {
                GameObject.Instantiate(prefab, Position, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Prefab is null.");
            }
        }

        public abstract void OnDestroy();

    }

    public enum BlockType
    {
        TestCube,
        Dirt,
        Stone,
        Water,
        Air,
        Sand,
        Glass
    }

}
