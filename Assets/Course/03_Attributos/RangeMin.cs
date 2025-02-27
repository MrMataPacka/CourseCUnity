using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class RangeMin : MonoBehaviour
    {
        [Range(1f, 100f)] //Esto sirve para delimitar esa variable dentro de ciertos valores
        public float shootSpeed;

        [Range(1, 10)]
        public int shootRate;

        [Min(2.5f)] //Valor minimo aceptado
        public float bulletsSpeed;

        [Min(5)]
        public int bulletsPerShoot;
    }
}
