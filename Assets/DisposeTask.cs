using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposeTask : MonoBehaviour
{
    public ClipboardManager _clipboardManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrokenComponent"))
        {
            Debug.Log("Vial disposed!");
            _clipboardManager.Task3Completed();
        }
    }


}
