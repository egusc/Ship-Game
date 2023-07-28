using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtonBehaviour : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(GameManager.instance.currentLevel);
    }
}
