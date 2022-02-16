using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject Menuu;
    public GameObject GameButtons;
    public void MenuButtonClick()
    {
        GameButtons.SetActive(false);
        Menuu.SetActive(true);
        Time.timeScale = 0;
    }

}
