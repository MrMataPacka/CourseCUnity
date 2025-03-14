using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course.PatronesDiseño.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
