using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButtonBehaviour : MonoBehaviour
{
    public void OnButtonPress()
    {
        SceneManager.LoadScene(GameManager.instance.nextLevel);
    }
}
