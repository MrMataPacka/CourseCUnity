using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Course.SOLID.Before
{
    public class PlayerInput : MonoBehaviour
    {		
        public InputHandler InputHandler;
        [Space]
        public float speedMovement = 15f;
        [Space]
        public UnityEvent OnInteract;
        public UnityEvent OnConsumeItem;

        private void Update()
        {
            // Movement
            ActionMovement();

            // Interaction
            ActionInteraction();

            // Consume Item
            ActionConsumeItem();
        }

        private void ActionMovement()
        {
            // Movement
            float inputHorizontal = InputHandler.GetAxisHorizontal();

            Vector3 direction = new Vector3(inputHorizontal, 0, 0);

            transform.Translate(direction * speedMovement * Time.deltaTime);
        }

        private void ActionInteraction()
        {
            // Interaction
            if (Input.GetKeyDown(KeyCode.E))
            {
                OnInteract.Invoke();
            }
        }

        private void ActionConsumeItem()
        {
            // Consume Item
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnConsumeItem.Invoke();
            }
        }

    }
}
