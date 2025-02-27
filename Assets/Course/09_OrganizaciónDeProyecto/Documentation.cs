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
            // Mejores convenciones cuando no es necesario documentar, sino que el c�digo se explique solo
        }

        /// <summary>
        /// Summary: Descripci�n Corta
        /// </summary>
        /// <remarks>
        /// Remarks: Descripci�n detallada de la funci�n
        /// </remarks>
        /// <param name="characterName"> Param: Descripci�n de la variable </param>
        /// <returns>
        /// Returns: Descripci�n del tipo de valor que devuelve
        /// </returns>

        private int GetId(string characterName)
        {
            return 1;
        }
    }
}
