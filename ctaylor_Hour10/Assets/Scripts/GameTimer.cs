using UnityEngine;
using TMPro; 

public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText; 
    private float playTime = 0f;

    void Update()
    {
        playTime += Time.deltaTime;

        int minutes = Mathf.FloorToInt(playTime / 60f);
        int seconds = Mathf.FloorToInt(playTime % 60f);
        int milliseconds = Mathf.FloorToInt((playTime * 100f) % 100f);

        timerText.text = $"{minutes:00}:{seconds:00}:{milliseconds:00}";
    }
}
