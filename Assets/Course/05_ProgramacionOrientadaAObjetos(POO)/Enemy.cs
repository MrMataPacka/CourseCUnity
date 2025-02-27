using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public abstract class Enemy : MonoBehaviour // Hace que como tal no se pueda usar por si sola, sino que solo se pueda heredar
    {
        [Header("ENEMY")]
        [SerializeField] private string _title; // Para propiedades privadas y su uso mas facilmente
        [SerializeField] protected int damage; // Protected permite a las clases hijos modificar la variable pero se mantiene privada para las clases externas
        [SerializeField] protected float health;

        public string Title 
        { 
            get  
            {
                Debug.Log("Putos todos putos aqui te agarras el puto titulo jajajjjjaajaja");
                return _title;
            } 
            
            //set  
            //{
            //    _title = value;
            //}
        
        } // Una propiedad permite dividir el GET y el SET, get es obtener un valor, set es pisar el valor dandole uno nuevo
        // Igual permite dar logica al llamar los metodos de la variable

        private void Start()
        {
            Attack();
        }

        public virtual void Attack() //Para hacer polimorfismo debemos hacer el metodo publico y agregarle el virtual (solo funciona con publicos) este permite sobreescribir la funcion desde el hijo
        {
            Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{damage}'");
        }

        public abstract void Defense(); // Obliga a usar esa función en los hijos
        
    }
}
