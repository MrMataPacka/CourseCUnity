using UnityEngine;

namespace Course
{
    public class Door : MonoBehaviour, Iinteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Door");
        }
    }
}
