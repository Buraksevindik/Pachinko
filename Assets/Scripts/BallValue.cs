using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class BallValue : MonoBehaviour
    {
        public Button ballybtn;
        public CashControl cashcontrol;
        public Text bettext;
        public float topdeger;
        public Text ballAtext;
        public CashControl cashControl;
        public float ballAmount;
        public Button ballAA;
        public Button ballAY;

        private void Start()
        {            
            cashcontrol = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<CashControl>();
            topdeger =10;
            ballAmount = 1;
        }
        public void BallY()
        {
            if (topdeger+10>cashcontrol.money)
            {
                ballybtn.interactable = false;
            }
            else
            {
                topdeger += 10;
                bettext.text = "Bet Amount : " + topdeger + "$";
            }
        }
        public void BallA() 
        {
                topdeger -= 10;
                bettext.text = "Bet Amount : " + topdeger + "$";
        }
        public void ballamountA()
        {
            //if (ballAmount-5<0)
            //{
            //    ballAA.interactable = false;
            //}
            //else
            //{
            ballAmount -= 5;
            ballAtext.text = "Ball Amount : " + ballAmount;
            //}
        }
        public void ballamountY()
        {
            ballAmount += 5;
            ballAtext.text = "Ball Amount : " + ballAmount;
        }
    }
}