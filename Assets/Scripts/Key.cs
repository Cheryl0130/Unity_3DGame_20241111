
using Fungus;
using UnityEngine;

namespace Cheryl
{
    public class Key : MonoBehaviour,IInteraction
    {
        [SerializeField, Header("Fungus_互動物件說明")]
        private Flowchart flowchartobject;
        [SerializeField, Header("撿取音效")]
        private AudioClip soundPickUp;


        private string flowchatMessage = "鑰匙_A";
        private AudioSource aud;
        private Rigidbody rig;
        private Collider col;
        private bool isPickup;
        public bool pickup=>isPickup;

        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
            aud = GetComponent<AudioSource>();

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
            isPickup=true;
            rig.isKinematic = true;
            col.enabled=false;
            transform.position = new Vector3(0, 0, -200);
            aud.PlayOneShot(soundPickUp);
            flowchartobject.SendFungusMessage(flowchatMessage);

        }
    }
}

