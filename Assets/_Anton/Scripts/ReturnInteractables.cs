using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnInteractables : MonoBehaviour
{
    private Dictionary<GameObject, Vector3> originalPositions = new Dictionary<GameObject, Vector3>();
    public LayerMask interactableLayer;

    void Start()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if ((interactableLayer.value & (1 << obj.layer)) != 0)
            {
                originalPositions[obj] = obj.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider _interactableToReturn)
    {
        if ((interactableLayer.value & (1 << _interactableToReturn.gameObject.layer)) != 0 && originalPositions.ContainsKey(_interactableToReturn.gameObject))
        {
            _interactableToReturn.transform.position = originalPositions[_interactableToReturn.gameObject];
        }
    }
    
}
