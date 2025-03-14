using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Course.PatronesDiseño.Mediator
{
    public class MainMenu : Menu
    {
        public Button playBtn;
        public Button settingsBtn;
        public Button exitBtn;
        public override void Hide()
        {
            throw new System.NotImplementedException();
        }

        public override void Show()
        {
            throw new System.NotImplementedException();
        }

        private void Start()
        {
            playBtn.onClick.AddListener(() => mediator.GoToPlay());
            settingsBtn.onClick.AddListener(() => mediator.GoToSettings());
            exitBtn.onClick.AddListener(() => mediator.GoToExit());
        }
    }
}
