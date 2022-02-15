using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class AddMoney : MonoBehaviour
    {
         public Text cashText;
         CashControl cashcontrol;
        private void Awake()
        {
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
        }
        public void Addmoney()
        {
            if (cashcontrol.money<10)
            {
                cashcontrol.money += 1000;
                PlayerPrefs.SetFloat("Money", (cashcontrol.money));
                cashText.text = "Cash : " + cashcontrol.money + "$";
            }
        }
    }
}
