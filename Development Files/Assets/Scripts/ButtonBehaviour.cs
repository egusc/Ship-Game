using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        SceneManager.LoadScene("Level1");
    }
}
