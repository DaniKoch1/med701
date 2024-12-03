using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OvenScript : MonoBehaviour
{
    public bool item1place
    { get; set; }

    public bool item2place
    { get; set; }

    public bool item3place
    { get; set; }

    private bool hasRun = false;

    public GameObject pointLight; // Drag your Point Light into this field in the Inspector

    private bool isLightOn = false; // Keeps track of the light's current state

    public GameObject[] objectsToHide; // Array to hold multiple GameObjects

    private bool areObjectsVisible = true; // Tracks the visibility state

    // This method will be called when the button is interacted with
    public void Microwave()
    {
        if (item1place && item2place && item3place)
        {
            AudioManager.Instance.PlaySound("Oven", 0.5f);
            pointLight.SetActive(true);
            ToggleVisibility();
            hasRun = true;
        }
        else if (!hasRun && !item1place && !item2place && !item3place)
        {
            AudioManager.Instance.PlaySound("Fail", 0.5f);
        }
        else
        {
            pointLight.SetActive(false);
        }
    }

    public void ToggleVisibility()
    {
        if (objectsToHide != null && objectsToHide.Length > 0)
        {
            areObjectsVisible = !areObjectsVisible; // Toggle the visibility state

            // Loop through each GameObject and set its active state
            foreach (GameObject obj in objectsToHide)
            {
                if (obj != null)
                {
                    obj.SetActive(areObjectsVisible);
                }
            }
        }
        else
        {
            Debug.LogWarning("Objects to hide are not assigned in the Inspector!");
        }
    }
}
