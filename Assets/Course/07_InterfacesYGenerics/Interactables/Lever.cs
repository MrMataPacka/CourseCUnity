using UnityEngine;

namespace Course
{
    public class Lever : MonoBehaviour, Iinteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Lever");
        }
    }
}
