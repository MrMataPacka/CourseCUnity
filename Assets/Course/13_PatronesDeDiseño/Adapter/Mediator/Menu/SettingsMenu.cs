using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Course.PatronesDiseño.Mediator
{
    public class SettingsMenu : Menu
    {
        public Button backBtn;
        public override void Hide()
        {
        }

        public override void Show()
        {
        }

        private void Start()
        {
            backBtn.onClick.AddListener(() => mediator.GoToMainMenu());
        }
    }
}
