using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.OrganizacionProyecto
{
    public class Documentation : MonoBehaviour
    {
        private void Start()
        {
            int myValue;
            myValue = GetId("Mariano");
            // No usar el Zombie Code, mucho comentario de codigo como BackUp, nunca dejarlo sino borrarlo
            // Mejores convenciones cuando no es necesario documentar, sino que el código se explique solo
        }

        /// <summary>
        /// Summary: Descripción Corta
        /// </summary>
        /// <remarks>
        /// Remarks: Descripción detallada de la función
        /// </remarks>
        /// <param name="characterName"> Param: Descripción de la variable </param>
        /// <returns>
        /// Returns: Descripción del tipo de valor que devuelve
        /// </returns>

        private int GetId(string characterName)
        {
            return 1;
        }
    }
}
