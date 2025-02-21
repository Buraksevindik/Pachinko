using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class Points : MonoBehaviour
    {
        public GameObject Player;
        public float degerr;
        public Text cashText;
        public CashControl cashcontrol;
        private void Awake()
        {
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
        }
        private void OnTriggerEnter2D(Collider2D info)
        {
            Destroy(info.gameObject);
            float toplam = (info.gameObject.GetComponent<PlayerSettings>().deger * degerr) / 2;
            cashcontrol.AdjustMoney(toplam);
            cashText.text = "Cash : " + cashcontrol.GetMoney().ToString() + "$";
            PlayerPrefs.SetFloat("Money", (cashcontrol.money));
        }
    }
}
