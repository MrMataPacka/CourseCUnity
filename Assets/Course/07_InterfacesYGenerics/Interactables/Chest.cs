using UnityEngine;

namespace Course

{
    public class Chest : MonoBehaviour, Iinteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Chest");
        }
    }
}
