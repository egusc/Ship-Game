using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI textmeshPro;
    public float timeRemaining = 30;
    bool timerIsRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText(timeRemaining.ToString("F2"));
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                textmeshPro.SetText(timeRemaining.ToString("F2"));
            }
            else
            {
                timerIsRunning = false;
                LevelController.instance.playerLose();
            }
        }
    }
}
