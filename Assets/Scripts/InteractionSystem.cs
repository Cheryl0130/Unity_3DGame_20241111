using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheryl
{
    public class InteractionSystem : MonoBehaviour
    {
        [Header("圖示資料")]
        [SerializeField]
        private Color rayColor = Color.red;
        [SerializeField, Range(1, 20)]
        private float rayLength = 10;
        [SerializeField]
        private LayerMask rayLayer;

        private void OnDrawGizmos()
        {
            Gizmos.color = rayColor;
            Gizmos.DrawRay(transform.position, transform.forward* rayLength);
        }
        private void Update()
        {
            Raycast();
        }
        private void Raycast()
        {
            bool isHit=Physics.Raycast(
                transform.position, transform.forward, out RaycastHit hit,rayLength,rayLayer);

            if (hit.collider == null) return;

            if (hit.collider.TryGetComponent(out IInteraction interaction))
            { 
              if(Input.GetKeyDown(KeyCode.Mouse0))
                {
                    interaction.Pickup();
                }
            }
        }
    }
}
   
