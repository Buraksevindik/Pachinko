using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pachinko
{
    public class CashControl : MonoBehaviour
    {
        BallValue ballvalueScript;
        public double money = 1000;
        public Button betBtn;
        public Text cashText;
        private void Awake()
        {
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        public double GetMoney()
        {
            return money;
        }
        public void AdjustMoney(double amount)
        {
            money += amount;
        }
        public void BetClicked()
        {
                if (money > 0)
                {
                   money -= ballvalueScript.topdeger*ballvalueScript.ballAmount;
                   cashText.text = "Cash : " + money + "$";
                }
                if (money <= 0)
                {
                  betBtn.interactable = false;
                }
        }
    }
}
