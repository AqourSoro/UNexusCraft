using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace NexusCraft

{
    public interface IPrefabModel : IModel
    {
        void InitializePrefabs(IList<GameObject> prefabs);
        GameObject GetPrefab(string key);
        bool IsLoaded { get; }
    }

    public class PrefabModel : AbstractModel, IPrefabModel, ICanGetSystem
    {
        private Dictionary<string, GameObject> prefabs = new Dictionary<string, GameObject>();
        public bool IsLoaded { get; private set; } = false;

        protected override void OnInit()
        {
            var addressableSystem = this.GetSystem<IAddressableSystem>();
            addressableSystem.LoadAllPrefabs(loadedPrefabs =>
            {
                Debug.Log($"Size of prefabs: {loadedPrefabs.Count}");
                InitializePrefabs(loadedPrefabs);
                Debug.Log("All prefabs loaded.");
            });
        }

        public void InitializePrefabs(IList<GameObject> loadedPrefabs)
        {
            foreach (var prefab in loadedPrefabs)
            {
                prefabs[prefab.name] = prefab;
                Debug.Log("Loaded: " + prefab.name);
            }
            IsLoaded = true;
        }

        public GameObject GetPrefab(string key)
        {
            prefabs.TryGetValue(key, out var prefab);
            return prefab;
        }
    }
}