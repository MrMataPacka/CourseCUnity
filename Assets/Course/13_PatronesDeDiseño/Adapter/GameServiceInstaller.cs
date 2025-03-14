using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño
{
    public class GameServiceInstaller : MonoBehaviour
    {		
        public  PlayerPrefsAdapter saveSystem;

        private void Awake()
        {
            GameServiceLocator.Instance.RegisterService<IDataSaver>(saveSystem);
        }
    }
}
