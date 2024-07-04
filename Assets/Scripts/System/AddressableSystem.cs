using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using System;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace NexusCraft
{

    public interface IAddressableSystem : ISystem
    {
        void LoadAllPrefabs(Action<IList<GameObject>> onLoaded);
    }


    public class AddressableSystem : AbstractSystem, IAddressableSystem
    {

        protected override void OnInit()
        {
            Debug.Log($"[{nameof(AddressableSystem)}] initiate");
        }

        public void LoadAllPrefabs(System.Action<IList<GameObject>> onLoaded)
        {
            Addressables.LoadResourceLocationsAsync("BlockPrefabs").Completed += handle =>
            {
                var locations = handle.Result;
                Debug.Log($"Location count: {locations.Count}");
        
                if (locations.Count > 0)
                {
                    Addressables.LoadAssetsAsync<GameObject>(locations, null).Completed += handle2 =>
                    {
                        onLoaded?.Invoke(handle2.Result);
                        Debug.Log("BlockPrefabs Loaded!");
                    };
                }
                else
                {
                    Debug.LogWarning("No prefabs found with the label 'BlockPrefabs'");
                }
            };
        }




        
    }
}


