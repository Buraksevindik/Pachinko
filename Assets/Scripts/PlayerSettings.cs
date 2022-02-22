using UnityEngine;
namespace Pachinko
{

    public class PlayerSettings : MonoBehaviour
    {
        public float deger;
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
