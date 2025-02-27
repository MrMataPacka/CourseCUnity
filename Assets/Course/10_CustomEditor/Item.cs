using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Course
{
    public class Item : MonoBehaviour
    {
        public ItemSO data;
        [Space]
        public Image itemImg;
        public TextMeshProUGUI itemTitleTxt;
        public TextMeshProUGUI itemPriceTxt;

        public void Consume()
        {
            itemImg.sprite = data.sprite;
            itemTitleTxt.text = data.title;
            itemPriceTxt.text = data.GetPrice();
        }

        private void Start()
        {
            Consume();
        }

        
    }
}
