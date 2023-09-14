using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;


namespace NexusCraft
{

    public interface IAddressableSystem : ISystem
    {

    }


    public class AddressableSystem : AbstractSystem, IAddressableSystem
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        protected override void OnInit()
        {
            Debug.Log($"[{nameof(AddressableSystem)}] initiate");
        }
    }
}


