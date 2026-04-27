using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    [SerializeField] bool timeIsRunning = true;

    // Update is called once per frame
    private void Awake()
    {
        ResetTimer();
        timeIsRunning = true;
        timerText.color = Color.white;
    }
    void Update()
    {
        if(timeIsRunning && remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            timerText.color = Color.red;
           
           
           
        }
        if(remainingTime == 0)
        {
          
            
            timeIsRunning = false;
            
            SceneManager.LoadSceneAsync("TitleScreen");
            ResetTimer();
        }
        


          
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void ResetTimer()
    {
        remainingTime = 10;
        timeIsRunning = false;
    }
}
