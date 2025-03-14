using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Course
{
    public class PlayerUI : MonoBehaviour
    {
        public TextMeshProUGUI healthTxt;

        public void UpdateHealth(int health)
        {
            healthTxt.text = $"Health: {health}";
        }
    }
}
