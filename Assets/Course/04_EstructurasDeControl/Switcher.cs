using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public enum Eplatform  //Enum sirven para mejorar el uso de datos en el edito de Unity, tiene su index
    {
        None,
        Pc,
        Xbox,
        Playstation,
        Switch
    }
    public class Switcher : MonoBehaviour
    {
        public int weaponType;
        public string enemyClass;
        public Eplatform currentPlatform;

        private void Start()
        {
            //If elseif, cuando hay muchas variantes, dificil de manejar, horrible de leer
            //Switch mejora eso

            switch (weaponType)
            {
                case 0:
                    //Hace algo
                    break;
                case 1:
                    break;
                case 2: 
                    break;
                case 3:
                    break;
                case 4:
                    break;

                default:
                    //Hace algo
                    break;
            }

            switch (enemyClass)
            {
                case "Archer":
                    //Hace algo
                    break;

                default:
                    //Hace algo
                    break;
            }

            switch (currentPlatform)
            {
                case Eplatform.None:
                    break;

                case Eplatform.Pc:
                    break;

                case Eplatform.Xbox:
                    break;

                case Eplatform.Playstation:
                    break;

                case Eplatform.Switch:
                    break;
                
                default:
                    break;
            }
        }
    }
}
