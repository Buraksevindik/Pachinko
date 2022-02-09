using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pachinko {
    public class BetClicked : MonoBehaviour
    {
        int f = 0;
        public GameObject Player;
        //public PlayerSettings playerSettings;
        float x;
        float y;
        float z;
        Vector3 pos;
        BallValue ballvalueScript;
        public double ballamount;
       
        private void Awake()
        {
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        IEnumerator topat()
        {
            /*ballamount u sabitlendi(normalde while döngüsünde direkt olarak ballvalue.ballamount dan çaðýrýyorduk ve o her seferinde güncel halini getiriyor
            böylece 6 top seçip bet butonuna bastýktan sonra topun saysýný yükselttiðimizde güncel sayý kadar top oluþturuyor ve 6 topun parasýný alýyordu)*/
            ballamount = ballvalueScript.ballAmount;
            while (f < ballamount)
            {
                f++;
                x = Random.Range(-2.28f, -0.68f);
                y = 15.5f;
                z = 0;
                pos = new Vector3(x, y, z);
                transform.position = pos;
                Instantiate(Player, pos, Quaternion.identity);
               yield return new WaitForSecondsRealtime(0.3f);            }
            f = 0;
        }
        public void Betclicked()
        {
            StartCoroutine(topat());
        }
    }
}