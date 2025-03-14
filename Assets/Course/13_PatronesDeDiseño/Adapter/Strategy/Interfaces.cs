using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Course.PatronesDiseño.Strategy
{
    public interface IWeapon
    {
        void Attack();
    }

    public interface IDamage
    {
        void DoDamage(int damage);
    }
}
