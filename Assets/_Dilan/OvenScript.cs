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

    public void Microwave()
    {
        if (item1place && item2place && item3place)
        {
            SoundManager.PlaySound(SoundManager.Sound.Oven);
        }
    }

}
