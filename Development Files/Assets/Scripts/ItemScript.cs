using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private bool isCollected = false;

    // Update is called once per frame
    void Update()
    {
        if(isCollected)
        {
            Destroy(gameObject);
            LevelController.instance.incrementPoints();
        }
    }
    void OnTriggerEnter2D(Collider2D other) {  
        if(other.gameObject.CompareTag("Player"))
        {
            isCollected = true;
        }
    }  
}
