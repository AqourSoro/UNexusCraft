using System.Collections.Generic;
using UnityEngine;
using QFramework;

namespace NexusCraft

{
    public interface IPrefabModel : IModel
    {
        //void InitializePrefabs(IList<GameObject> prefabs);
        GameObject GetPrefab(string key);
        bool IsLoaded { get; }
    }

    public class PrefabModel : AbstractModel, IPrefabModel, ICanGetSystem
    {
        private Dictionary<string, GameObject> prefabs = new Dictionary<string, GameObject>();
        public bool IsLoaded { get; private set; } = false;

        protected override void OnInit()
        {
            //load prefabs here
        }

        

        public GameObject GetPrefab(string key)
        {
            prefabs.TryGetValue(key, out var prefab);
            return prefab;
        }
    }
}