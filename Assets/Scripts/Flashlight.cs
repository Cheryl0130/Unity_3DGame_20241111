using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
    public class Flashlight : MonoBehaviour, IInteraction
    {
        public void Interaction()
        {
            print($"<color=#3f3>¤¬°Ê:{name}</color>");
        }

        public void Pickup()
        {
            print($"<color=#37f>¾ß¨ú:{name}</color>");
        }
    }
}
   
