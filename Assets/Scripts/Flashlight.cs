using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
    public class Flashlight : MonoBehaviour, IInteraction
    {
        public void Interaction()
        {
            print($"<color=#3f3>����:{name}</color>");
        }

        public void Pickup()
        {
            print($"<color=#37f>�ߨ�:{name}</color>");
        }
    }
}
   
