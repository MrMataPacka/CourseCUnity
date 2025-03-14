using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño
{
    public class GameManager : MonoBehaviour
    {
        //Codigo para llamar el IDataSaver que es usado como ServiceLocator y
        //que combina el adapter (para no reescribir codigo de mas)
        //y el singleton (que nos ayuda a que solo sea una instancia)

        /*private IDataSaver _dataSaver; 
        private void Start()
        {
            _dataSaver = GameServiceLocator.Instance.GetService<IDataSaver>();

        }*/

        public BattleFacade battleFacade; //Intermediaro entre muchas clases y el gameManager,
                                          //para no gestionar aqui quien hace que en que momento

        public void BattleStart()
        {
            battleFacade.BattleStart();
        }

        public void BattleEnd()
        {
            battleFacade.BattleEnd();
        }
    }
}
