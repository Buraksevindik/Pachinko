using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class GameController : MonoBehaviour
    {
        public Button ballAA;
        public Button ballAY;
        public Button betBtn;
        public Button ballabtn;
        public Button ballybtn;
        public Button addmoneyBtn;
        public BallValue ballAmount;
        public CashControl cashcontrol;
        public BetClicked betclicked;
        public BallValue ballvalueScript;
        private void Awake()
        {
            betclicked = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BetClicked>();
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        void Update()
        {
            //AddMoneyButton Control
            if (cashcontrol.money<10)
            {
                addmoneyBtn.interactable = true;
            }
            else
            {
                addmoneyBtn.interactable = false;
            }
            //BetButton BallyButton Control
            if (ballvalueScript.topdeger > cashcontrol.money)
            {
                betBtn.interactable = false;
                ballybtn.interactable = false;
            }
            else
            {
                ballybtn.interactable = true;
            }
            if ((ballvalueScript.ballAmount * (ballvalueScript.topdeger+10)) > cashcontrol.money)
            {
                ballybtn.interactable = false;
            }
            if (ballvalueScript.topdeger + cashcontrol.money % 10 == cashcontrol.money)
            {
                ballybtn.interactable = false;
            }
            //ballAA/ballAY Control
            if (ballvalueScript.ballAmount - 5 <= 0)
            {
                ballAA.interactable = false;
            }
            else
            {
                ballAA.interactable = true;
            }
            if ((ballvalueScript.ballAmount + 5) * ballvalueScript.topdeger >= cashcontrol.money)
            {
                ballAY.interactable = false;
            }
            else
            {
                ballAY.interactable = true;
            }
            if (ballvalueScript.topdeger == 10)
            {
                ballabtn.interactable = false;
            }
            else
            {
                ballabtn.interactable = true;
            }
        }
    }
}

