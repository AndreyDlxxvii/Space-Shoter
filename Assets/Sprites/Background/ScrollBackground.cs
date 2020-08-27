using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float Speed = -2f;
    public float LowerYValue = -20f;
    public float UpperYValue = 40f;

    void Update()
    {
        transform.Translate(0f, Speed * Time.deltaTime, 0f);
        if (transform.position.y <= LowerYValue)
        {
            transform.Translate(0f, UpperYValue, 0f);
        }
    }
}
