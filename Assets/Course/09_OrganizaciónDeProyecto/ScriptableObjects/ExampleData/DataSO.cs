using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    [CreateAssetMenu(fileName = "New Data", menuName = "ScriptableObjects/Data", order = 2)] // Un solo template de Personaje o Enemigos
    public class DataSO : ScriptableObject
    {
        [Header("Visual")]
        public string title;
        public Sprite sprite;

        [Header("Stats")]
        public float health = 100;
        public int damage = 15;

        public string GetPrintStats()
        {
            return $"Stats: health({health}), damage({damage})";
        }
    }
}
