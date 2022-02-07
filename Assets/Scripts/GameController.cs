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
        public BallValue ballAmount;
        public CashControl cashcontrol;
        public BetClicked betclicked;
        public BallValue ballvalueScript;
        public double modalma;
        private void Awake()
        {
            betclicked = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BetClicked>();
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        void Update()
        {
            //BallY/BetBtn Control
            if (ballvalueScript.topdeger > cashcontrol.money)
            {
                betBtn.interactable = false;
                ballybtn.interactable = false;
            }
            else
            {
                //betBtn.interactable = true;
                ballybtn.interactable = true;
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
            if ((ballvalueScript.ballAmount * ballvalueScript.topdeger) > cashcontrol.money)
            {
                ballybtn.interactable = false;
                betBtn.interactable = false;
            }
            else
            {
                betBtn.interactable = true;
            }
            if ((ballvalueScript.ballAmount + 5) * ballvalueScript.topdeger >= cashcontrol.money)
            {
                ballAY.interactable = false;
            }
            else
            {
                ballAY.interactable = true;
            }
            //---------------
            if (ballvalueScript.topdeger + cashcontrol.money % 10 == cashcontrol.money)
            {
                ballybtn.interactable = false;
            }
            //BallA Control
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

