using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Mediator
{
    public abstract class Menu : MonoBehaviour
    {
        public MenuMediator mediator;

        public abstract void Show();
        public abstract void Hide();
    }
}
