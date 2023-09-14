using UnityEngine;
using QFramework;

public class UNexusCraft : Architecture<UNexusCraft>
{
    
    protected override void Init()
    {
        Debug.Log($"[{nameof(UNexusCraft)}] Architecture initialized. Welcome to UNexus Craft!");

        Debug.Log($"[{nameof(UNexusCraft)}] Architecture launch finished.");


    }
}
