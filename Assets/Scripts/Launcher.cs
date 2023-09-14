using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;


namespace NexusCraft
{
    public class Launcher : MonoBehaviour, IController
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Debug.Log($"[{nameof(Launcher)}] application initiate at {System.DateTime.Now}");
            GetArchitecture();

        }

        private void Start()
        {
            Debug.Log($"[{nameof(Launcher)}] started.");
        }


        public IArchitecture GetArchitecture()
        {
            return UNexusCraft.Interface;
        }
    }
}


