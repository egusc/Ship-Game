using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    private int currentPoints = 0;
    private int maxPoints = 0;
    TextMeshProUGUI textmeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText("Points collected: {0} / {1}", currentPoints, maxPoints);
    }

    
    public void editMaxPoints(int newMaxPoints)
    {
        maxPoints = newMaxPoints;
        textmeshPro.SetText("Points collected: {0} / {1}", currentPoints, maxPoints);
    }

    public void editCurrentPoints(int newCurrentPoints)
    {
        currentPoints = newCurrentPoints;
        textmeshPro.SetText("Points collected: {0} / {1}", currentPoints, maxPoints);
    }

}
