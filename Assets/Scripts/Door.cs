using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

namespace Cheryl
{
    public class Door : MonoBehaviour, IInteraction
    {
        [SerializeField, Header("Fungus_互動物件說明")]
        private Flowchart flowchartobject;
        [SerializeField,Header("這扇門的鑰匙")]
        private Key key;

        private string messageNoKey = "門_B_沒有鑰匙";
        private string messageHasKey = "門_B_有鑰匙";
        private bool hasKey;

        public void Interaction()
        {
            print($"<color=#3f3>互動:{name}</color>");

            hasKey = key.pickUp;
            print($"<是否有鑰匙>{hasKey}");

            if(!hasKey)flowchartobject.SendFungusMessage(messageNoKey);
            else flowchartobject.SendFungusMessage(messageHasKey);
        }

        public void Pickup()
        {
            print($"<color=#37f>撿取:{name}</color>");
            Interaction();
        }

    }
}
