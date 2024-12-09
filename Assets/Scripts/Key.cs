using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
    public class Key : MonoBehaviour,IInteraction
    {
        private Rigidbody rig;
        private Collider col;
        private bool isPickUp;

        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
        }
        // Start is called before the first frame update
        public void Interaction()
        {
            print($"<color=#3f3>互動:{name}</color>");
        }

        // Update is called once per frame

        public void Pickup()
        {
            print($"<color=#37f>撿取:{name}</color>");
            isPickUp=true;
            rig.isKinematic = true;
            col.enabled=false;
            transform.position = new Vector3(0, 0, -200);
        }
    }
}

