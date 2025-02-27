using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class TipoStruct : MonoBehaviour
    {
        // Struct, empaquetar variables, mas facil de manejar los datos y mas rapido
        public string playerName;
        public int playerHealth;
        public bool playerIsDead;


        [System.Serializable]
        public struct PlayerData
        {
            public string name;
            public int health; 
            public bool isDead;
            public int ammo;
        }

        public PlayerData playerData;
        
        private void Start ()
        {
            playerData.name = "Mariano";
            playerData.health = 100;
            playerData.isDead = false;

        }
        //Facilidad de usar diferentes variables sin tener que pasarlas por separado

        private void ChangeInfo(PlayerData data)
        {
            data.isDead = true;
        }
    }
}
