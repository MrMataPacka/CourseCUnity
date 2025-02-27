using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class HeaderSpace : MonoBehaviour
    {
        [Header("Stats")] // Header sirve para dividir partes variables y que en el editor sean más manejables
        public string displayName;
        [Space] //Genera espacios visuales en el editor para facilitar lectura
        public int health;
        public int mana;
        [Space(24)] //Se le pueden pasar valores int para determinar la cantidad de espacio visual
        public bool isAlive;

        [Header("References")]
        public CapsuleCollider capsuleCollider;
    }
}
