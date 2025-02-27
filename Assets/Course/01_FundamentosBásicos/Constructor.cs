using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Constructor : MonoBehaviour 
    {
        private void Start()
        {
            Weapon myWeapon = new Weapon();

            myWeapon.Shoot();
        }
    }

    public class Weapon // Es un metodo especial que inicializa un objecto cuando una clase es creada
                        //Tienen el mismo nombre de la clase
                        // El constructor es automaticamente llamado cuando un objeto es creado
    {
        int ammo;

        public Weapon()
        {
            ammo = 30;   
        }

        public Weapon(int ammo)
        {
            this.ammo = ammo;
        }

        public void Shoot()
        {

        }
    }
}
