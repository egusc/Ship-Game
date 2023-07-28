using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidRotate : MonoBehaviour
{
    float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {
        rotationAngle = Random.Range(-1.0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotationAngle);
    }
}
