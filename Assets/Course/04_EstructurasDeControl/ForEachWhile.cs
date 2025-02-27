using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ForEachWhile : MonoBehaviour
    {
        public int[] weaponAmmoArray;

        private void CheackWeaponAmmo()
        {
            for (int i = 0; i < weaponAmmoArray.Length; i++) //En base a una variable i que empieza en un numero determinado; mientras sea menor a un valor hara el ciclo; al final harà la acción i++ o lo que sea
            {
                Debug.Log($"Index {i} - Ammo: {weaponAmmoArray[i]}");
            }

            foreach (int weaponAmmo in weaponAmmoArray) //Por cada variable en la lista xomo en este caso weaponAmmo, se ejecuta el ciclo
            {
                Debug.Log($"Index ? - Ammo: {weaponAmmo}");
            }
        }

        private IEnumerator Fade() //Permite almacenar colecciones y después filtrarlas
        {
            float alpha = 1;
            while (alpha > 0)
            {
                alpha -= Time.deltaTime; 
                yield return null;
            }

            //Do something


            yield return null;
        }

    }
}
