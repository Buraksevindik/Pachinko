using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void SahneGecis(int x=1)
    {
        SceneManager.LoadScene(x);
        Time.timeScale = 1;
    }
}
