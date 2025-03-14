using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Strategy
{
    public class Sword : MonoBehaviour, IWeapon
    {
        private int _damage = 0;
        private float _attackRadius = 200f;
        public void Attack()
        {
            var hits = Physics2D.OverlapCircleAll(transform.position, _attackRadius);

            if (hits[0] != null )
            {
                for ( int i = 0; i < hits.Length; i++ )
                {
                    var otherDamage = hits[i].GetComponent<IDamage>();
                    otherDamage?.DoDamage(_damage);
                }
            }
        }
    }
}
