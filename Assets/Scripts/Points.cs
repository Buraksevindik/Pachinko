using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class Points : MonoBehaviour
    {
        public GameObject Player;
        public double degerr;
        public Text cashText;
        public CashControl cashcontrol;
        private void Awake()
        {
           
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
        }
        private void OnTriggerEnter2D(Collider2D info)
        {
            Destroy(info.gameObject);
            double toplam = (info.gameObject.GetComponent<PlayerSettings>().deger * degerr) / 2;
            cashcontrol.AdjustMoney(toplam);
            cashText.text = "Cash : " + cashcontrol.GetMoney().ToString() + "$";
        }
    }
}
