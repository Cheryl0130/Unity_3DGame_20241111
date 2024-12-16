using Fungus;
using UnityEngine;

namespace Cheryl
{

    public class Flashlight : MonoBehaviour, IInteraction
    {
        [SerializeField, Header("手電筒位置")]
        private Transform flashlightPoint;
        [SerializeField, Header("手電筒互動按鍵")]
        private KeyCode keyFlashlight = KeyCode.F;
        [SerializeField, Header("手電筒聚光燈")]
        private GameObject spotLight;
        [SerializeField, Header("Fungus_互動物件說明")]
        private Flowchart flowchartObject;
        [SerializeField, Header("撿取音效")]
        private AudioClip soundPickUp;
        [SerializeField,Header("開關音效")]
        private AudioClip soundSwitch;

        private string flowchatMessage = "手電筒";
        private Rigidbody rig;
        private Collider col;
        private bool isPickUp;
        private AudioSource aud;

        private void Awake()
        {
            rig = GetComponent<Rigidbody>();
            col = GetComponent<Collider>();
            aud=GetComponent<AudioSource>();
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
                aud.PlayOneShot(soundSwitch, Random.Range(1, 1.5f));
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
            flowchartObject.SendFungusMessage(flowchatMessage);
            aud.PlayOneShot(soundPickUp);
        }
    }
}
   
