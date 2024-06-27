using System.Collections.Generic;
using QFramework;
using UnityEngine;
using Utils;

//May be use IBlock with BlockSolid and BlockLiquid as father?
namespace NexusCraft
{
    public interface IBlockModel : IModel
    {
        void AddBlock(Vector3Int position, BaseBlock block);
        void RemoveBlock(Vector3Int position);
        BaseBlock GetBlock(Vector3Int position);
    }
}
