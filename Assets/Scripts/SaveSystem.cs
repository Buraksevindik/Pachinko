using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pachinko
{
    public class SaveSystem : MonoBehaviour
    {      
        public Text MenumoneyText;
        void Start()
        {
            MenumoneyText.text = "Money : " + PlayerPrefs.GetFloat("Money");
        }

    }
}