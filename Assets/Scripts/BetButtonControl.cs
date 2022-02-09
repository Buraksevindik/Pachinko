using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class BetButtonControl : MonoBehaviour
    {
        public Button betBtn;
        public CashControl cashcontrol;
        public BallValue ballvalueScript;
        private void Awake()
        {
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        private void Update()
        {
            if ((ballvalueScript.ballAmount * ballvalueScript.topdeger) > cashcontrol.money)
            {
                betBtn.interactable = false;
            }
            else
            {
                betBtn.interactable = true;
            }
        }

    }
}
