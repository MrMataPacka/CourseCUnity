using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Strategy
{
    public class Bow : MonoBehaviour, IWeapon
    {
        public GameObject arrowPrefab;
        public Transform spawnTransform;

        public void Attack()
        {
            Instantiate(arrowPrefab, spawnTransform.position, spawnTransform.rotation);
        }
    }
}
