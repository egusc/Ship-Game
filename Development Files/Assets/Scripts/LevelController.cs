using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int maxPoints;
    private int currentPoints = 0;
    public TextController scoreText;
    public GameObject gameManager;
    public static LevelController instance;

    public string currentLevel;
    public string nextLevel;
 
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Start() {
        scoreText.editMaxPoints(maxPoints);
        GameManager.instance.currentLevel = currentLevel;
        GameManager.instance.nextLevel = nextLevel;
    }

    private void Update() {
        if(currentPoints == maxPoints)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    public void incrementPoints()
    {
        currentPoints++;
        scoreText.editCurrentPoints(currentPoints);
    }
    

    public void playerLose()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
