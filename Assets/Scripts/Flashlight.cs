using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
   
    public class Flashlight : MonoBehaviour, IInteraction
    {
        [SerializeField, Header("手電筒位置")]
        private Transform flashlightPoint;

        private Rigidbody rig;
        private Collider col;
        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }
        public void Interaction()
        {
            print($"<color=#3f3>互動:{name}</color>");
        }

        public void Pickup()
        {
            print($"<color=#37f>撿取:{name}</color>");
            transform.position= flashlightPoint.position;
            col.enabled=false;
            rig.useGravity= false;
        }
    }
}
   
