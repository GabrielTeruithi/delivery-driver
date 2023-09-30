using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private float steerSpeed = 0.1f;
    private float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0,moveSpeed,0);
    }
}
