using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pachinko
{

    public class PlayerSettings : MonoBehaviour
    {
        public double deger;
        public BallValue ballvalueScript;
        private void Awake()
        {
            ballvalueScript = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<BallValue>();
        }
        void Start()
        {
            deger = ballvalueScript.topdeger;
            Physics2D.IgnoreLayerCollision(6, 6);
        }
    }
}
