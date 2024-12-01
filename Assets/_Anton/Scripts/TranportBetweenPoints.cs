using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TranportBetweenPoints : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float duration = 2.0f;


    public LightManager LightManager;
    private bool isMoving = false;
    private float t = 0.0f;

    private bool hasMoved = false;

    public bool item1ready
        { get; set; }

    public bool item2ready
        { get; set; }

    public bool item3ready
        { get; set; }

    private void Start()
    {
        //Just set the position to the A transform
        transform.position = pointA.position;
    }
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
        Debug.Log("start moving called");
        if (!isMoving && !hasMoved && item1ready && item2ready && item3ready)
        {
            AudioManager.Instance.PlaySound("Sucess");
            isMoving = true;
            t = 0.0f;
            hasMoved = true;
            LightManager.ToggleLight();
        }
        else if (!isMoving && !hasMoved && !item1ready && !item2ready && !item3ready)
        {
            AudioManager.Instance.PlaySound("Fail");
        }
      
    }
}
