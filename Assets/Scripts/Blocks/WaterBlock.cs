using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public class WaterBlock : BaseBlock
    {
        public WaterBlock(Vector3Int position) : base(position, BlockType.Water) { }

        public override void OnGenerate()
        {
            // WaterBlock specific generation logic
            Debug.Log($"WaterBlock generated at {Position}");
        }

        public override void OnDestroy()
        {
            // WaterBlock specific destruction logic
            Debug.Log($"WaterBlock destroyed at {Position}");
        }
        
    }
}
