using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Strategy
{
    [RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
    public class Arrow : MonoBehaviour
    {
        private int _damage = 10;
        private float _speed = 5f;

        private void Awake()
        {
           GetComponent<Rigidbody2D>().velocity = transform.right * _speed;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            IDamage otherDamage = collision.GetComponent<IDamage>();
            otherDamage?.DoDamage(_damage);

            Destroy(this);
        }
    }
}
