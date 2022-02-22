using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Pachinko {
    public class BetClicked : MonoBehaviour
    {
        public Button betbutton;
        int f = 0;
        public GameObject Player;
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
            /*ballamount u sabitlendi(normalde while d�ng�s�nde direkt olarak ballvalue.ballamount dan �a��r�yorduk ve o her seferinde g�ncel halini getiriyor
            b�ylece 6 top se�ip bet butonuna bast�ktan sonra topun says�n� y�kseltti�imizde g�ncel say� kadar top olu�turuyor ve 6 topun paras�n� al�yordu)*/
            ballamount = ballvalueScript.ballAmount;
            while (f < ballamount)
            {
                f++;
                x = Random.Range(-2.28f, -0.68f);
                y = 15.5f;
                z = 0;
                pos = new Vector3(x, y, z);
                transform.position = pos;
                betbutton.interactable = false;
                Instantiate(Player, pos, Quaternion.identity);
                GetComponent<BetButtonControl>().enabled = false;
                betbutton.interactable = false;
                yield return new WaitForSecondsRealtime(0.2f);
            }
            GetComponent<BetButtonControl>().enabled = true;
            f = 0;
        }
        public void Betclicked()
        {
            StartCoroutine(topat());
            
        }
    }
}