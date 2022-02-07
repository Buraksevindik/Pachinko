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
        private void Awake()
        {
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        IEnumerator topat()
        {
            while (f < ballvalueScript.ballAmount)
            {
                f++;
                x = Random.Range(-2.28f, -0.68f);
                y = 15.5f;
                z = 0;
                pos = new Vector3(x, y, z);
                transform.position = pos;
                Instantiate(Player, pos, Quaternion.identity);
               yield return new WaitForSecondsRealtime(0.3f);
            }
            f = 0;
        }
        public void Betclicked()
        {
            StartCoroutine(topat());
        }
    }
}

