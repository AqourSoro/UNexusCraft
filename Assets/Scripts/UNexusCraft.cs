using NexusCraft;
using UnityEngine;
using QFramework;

public class UNexusCraft : Architecture<UNexusCraft>
{
    
    protected override void Init()
    {
        Debug.Log($"[{nameof(UNexusCraft)}] Architecture initialized. Welcome to UNexus Craft!");

        Debug.Log($"[{nameof(UNexusCraft)}] Architecture launch finished.");

        RegisterSystem<IAddressableSystem>(new AddressableSystem());
        
        RegisterModel<IBlockModel>(new BlockModel());
        RegisterModel<IChunkModel>(new ChunkModel());
        RegisterModel<IPrefabModel>(new PrefabModel());
        
        
        
        Debug.Log($"{nameof(UNexusCraft)} Architecture launch finished.");

    }
}
