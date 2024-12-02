using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
   
    public class Flashlight : MonoBehaviour, IInteraction
    {
        [SerializeField, Header("��q����m")]
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
            print($"<color=#3f3>����:{name}</color>");
        }

        public void Pickup()
        {
            print($"<color=#37f>�ߨ�:{name}</color>");
            transform.position= flashlightPoint.position;
            col.enabled=false;
            rig.useGravity= false;
        }
    }
}
   
