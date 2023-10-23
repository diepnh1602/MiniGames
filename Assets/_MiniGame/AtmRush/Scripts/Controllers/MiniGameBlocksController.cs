using DG.Tweening;
using UnityEngine;

namespace AtmRush
{
    public class MiniGameBlocksController : MonoBehaviour
    { 
        private void OnTriggerEnter(Collider other)
        {
            if(other.CompareTag("MiniGamePlayer"))
            {
                transform.DOMoveZ(transform.position.z-3f, 2f);
            }
        }
    }
}
