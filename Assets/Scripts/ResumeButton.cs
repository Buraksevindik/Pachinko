using UnityEngine;

public class ResumeButton : MonoBehaviour
{
    public GameObject Menuu;
    public GameObject GameButtons;
    public void resumeButtonClick()
    {
        GameButtons.SetActive(true);
        Menuu.SetActive(false);
        Time.timeScale = 1;
    }
}