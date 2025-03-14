using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Mediator
{
    public class MenuMediator : MonoBehaviour
    {
        public Menu[] menus;
        // 0 - Main  menu
        // 1 - Play
        // 2 - Settings
        // 3 - Exit

        public int currentIndex = 0;
        public int lastIndex = 0;

        private void ChangeMenu(int index)
        {
            currentIndex = index;

            menus[lastIndex].Hide();
            menus[currentIndex].Show();

            lastIndex = currentIndex;
             
        }

        public void GoToMainMenu()
        {
            ChangeMenu(0);
        }
        public void GoToPlay()
        {
            ChangeMenu(1);
        }
        public void GoToSettings()
        {
            ChangeMenu(2);
        }
        public void GoToExit()
        {
            ChangeMenu(3);
        }
    }
}
