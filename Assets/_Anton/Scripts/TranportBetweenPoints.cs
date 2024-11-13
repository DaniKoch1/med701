using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranportBetweenPoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float duration = 2.0f;

    private bool isMoving = false;
    private float t = 0.0f;

    void Update()
    {
        if (isMoving)
        {
            t += Time.deltaTime / duration;
            transform.position = Vector3.Lerp(pointA.position, pointB.position, t);

            if (t >= 1.0f)
            {
                isMoving = false;
                t = 0.0f;  // Reset t for the next call
            }
        }
    }

        public void StartMoving()
    {
        isMoving = true;
        t = 0.0f;
    }
}
