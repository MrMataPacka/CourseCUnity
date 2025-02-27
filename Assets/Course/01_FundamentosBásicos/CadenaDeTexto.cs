using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class CadenaDeTexto : MonoBehaviour
    {
        string myString;

        private void Start()
        {
            myString = "Mariano";
            myString = "Mariano" + " " + "Sosa"; //No recomendable, genera basura, cada mas crea un nuevo string

            int age = 27;
            myString = "Marianos's Birthday: " + age.ToString(); //Igualmente sucio por encadanenar mas de un string




            myString = string.Format("{0}'s Birthday: {1}", "Mariano",age); //Optimo no genera basura
            myString = $"Marianos's Birthday: {age}"; //Igualmente optimo para no tener que usar el format

            myString = "27_Mariano_Rifle";
            string[] characterInfo = myString.Split('_'); // Esta funcion tendrìa
            // characterInfo[0] = "27";
            // characterInfo[1] = "Mariano";
            // chatacterInfo[2] = "Rifle";
        }
    }
}
