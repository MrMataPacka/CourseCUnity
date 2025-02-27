using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Dictionary")] // Como los array pero sin la restricción de solo accder valores en base a un int
        public Dictionary<string, GameObject> characterDictionary;

        private void Start ()
        {
            // Iniciar Diccionarios
            characterDictionary = new Dictionary<string, GameObject>();


            // Add
            for (int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]); //Personaje con un nombre: Orco
            }

            // Remove
            characterDictionary.Remove("");

            // Contains
            bool contains = characterDictionary.ContainsKey("Orc");

            // Read
            GameObject myValue = characterDictionary["Orc"];

            // Amount 
            int amount = characterDictionary.Count;

            // Clear
            characterDictionary.Clear();
        }
    }
}
