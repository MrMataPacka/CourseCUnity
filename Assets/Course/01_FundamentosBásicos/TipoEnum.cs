using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Attacktype
{
    None,
    Fire,
    Ice,
    Sword,
    Punch
}
namespace Course
{
    
    public class TipoEnum : MonoBehaviour
    {
        // 0 = Fire
        // 1 = Ice
        // 2 = Sword
        // 3 = Punch
        public int attackTypeInt;

        public enum Attacktype
        {
            None,
            Fire,
            Ice,
            Sword,
            Punch
        }

        public Attacktype AttackTypeEnum = Attacktype.Sword;

        private void Start()
        {
            AttackTypeEnum = Attacktype.Fire;
        }
    }
}
