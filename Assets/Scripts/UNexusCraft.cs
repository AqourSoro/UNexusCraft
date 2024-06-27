using NexusCraft;
using UnityEngine;
using QFramework;

public class UNexusCraft : Architecture<UNexusCraft>
{
    
    protected override void Init()
    {
        Debug.Log($"[{nameof(UNexusCraft)}] Architecture initialized. Welcome to UNexus Craft!");

        Debug.Log($"[{nameof(UNexusCraft)}] Architecture launch finished.");

        RegisterModel<IBlockModel>(new BlockModel());
        RegisterModel<IChunkModel>(new ChunkModel());
        
        Debug.Log($"{nameof(UNexusCraft)} Architecture launch finished.");

    }
}
