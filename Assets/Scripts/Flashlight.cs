using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
   
    public class Flashlight : MonoBehaviour, IInteraction
    {
        [SerializeField, Header("手電筒位置")]
        private Transform flashlightPoint;
        [SerializeField,Header("手電筒互動按鍵")]
        private KeyCode keyFlashlight= KeyCode.F;
        [SerializeField, Header("手電筒聚光燈")]
        private GameObject spotLight;

        private Rigidbody rig;
        private Collider col;
        private bool isPickUp;

        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }

        private void Update()
        {
            Interaction();
        }

        public void Interaction()
        {
            if (!isPickUp) return;
            if(Input.GetKeyDown(keyFlashlight))
            {
                print($"<color=#3f3>互動:{name}</color>");
                spotLight.SetActive(!spotLight.activeInHierarchy);
            }
        }

        public void Pickup()
        {
            print($"<color=#37f>撿取:{name}</color>");
            isPickUp=true;
            transform.SetParent(flashlightPoint);
            transform.localPosition= Vector3.zero;
            transform.localEulerAngles= Vector3.zero;
            col.enabled=false;
            rig.useGravity= false;
        }
    }
}
   
