using UnityEngine;

public class AudioCanvasOpenClose : MonoBehaviour
{
    public GameObject Audio;
    public GameObject MenuCanvas;
    public void AudioButtonClick()
    {
        MenuCanvas.SetActive(false);
        Audio.SetActive(true);
        Time.timeScale = 0;
    }
}
