using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pachinko
{
    public class CashControl : MonoBehaviour
    {
        BallValue ballvalueScript;      
        public Button betBtn;
        public Text cashText;
        public float money;
        private void Awake()
        {
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
            money = PlayerPrefs.GetFloat("Money");
        }
        private void Start()
        {
            cashText.text ="Cash : "+ money+"$";
        }
        public double GetMoney()
        {
            return money;
        }
        public void AdjustMoney(float amount)
        {
            money += amount;
        }
        public void BetClicked()
        {
            if (money > 0)
            {
                money -= ballvalueScript.topdeger * ballvalueScript.ballAmount;
                cashText.text = "Cash : " + money + "$";
                PlayerPrefs.SetFloat("Money", money);
            }
        }
    }
}
