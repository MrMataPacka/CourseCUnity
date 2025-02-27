using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace Course
{
    public struct PlayerData
    {
        public int score;
        public bool isAlive;
    }
    public class JumpStatements : MonoBehaviour
    {		
        public PlayerData[] playerData;

        private void CheckMaxScore()
        {
            for (int i = 0; i < playerData.Length; i++)
            {
                // If score >= 10, win
                if (playerData[i].score >= 10)
                {
                    //Winner
                    break; //Rompe el ciclo desde el for o el while
                }
            }
        }

        private void CheckPlayersScore()
        {
            for (int i = 0; i < playerData.Length; i++)
            {
                // If isnt alive, skip
                if (!playerData[i].isAlive)
                {
                    continue; //Continua hacia el siguiente index de la comprobación saltando lo que había abajo de este
                }
                //Otra logica
            }
        }

        private void CheckPlayerScore(int index)
        {
            // If isnt alive dont execute
            if (!playerData[index].isAlive)
            {
                return; // Salida rapida sin tocar lo demas del codigo
            }
            //Otra logica
        }

    }
}
