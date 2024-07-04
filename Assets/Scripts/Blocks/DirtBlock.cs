using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public class DirtBlock : BaseBlock
    {
        public DirtBlock(Vector3Int position) : base(position, BlockType.Dirt)
        {
            
        }

        public override void OnGenerate(GameObject prefab)
        {
            Debug.Log($"DirtBlock generated at {Position}");
            base.OnGenerate(prefab);
        }

        public override void OnDestroy()
        {
            Debug.Log($"DirtBlock destroyed at {Position}");
        }
    }
}