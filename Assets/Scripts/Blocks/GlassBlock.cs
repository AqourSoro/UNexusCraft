using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NexusCraft
{
    public class GlassBlock : BaseBlock
    {
        public GlassBlock(Vector3Int position) : base(position, BlockType.Water) { }

        public override void OnGenerate(GameObject prefab)
        {
            // WaterBlock specific generation logic
            base.OnGenerate(prefab);
            Debug.Log($"GlassBlock generated at {Position}");
        }

        public override void OnDestroy()
        {
            // WaterBlock specific destruction logic
            Debug.Log($"GlassBlock destroyed at {Position}");
        }
        
    }
}
