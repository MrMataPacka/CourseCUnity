using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Template
{
    public class Orc : Character
    {
        protected override bool CanAttack()
        {
            return true;
        }
        protected override void DoAttack()
        {
            //Attack
        }

        protected override void DamageReceived(bool isDead)
        {
            if (isDead)
            {
                // Drop Something
                return;
            }
            Debug.Log("HA HA HA");
        }

    }
}
