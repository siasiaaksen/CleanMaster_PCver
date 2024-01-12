using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StainCount : MonoBehaviour
{
    public TextMeshProUGUI staincountText;
    public int staincount = 0;
    public int staingameObject;

    void Start()
    {
        GameObject[] stainObjects = GameObject.FindGameObjectsWithTag("stain");
        staingameObject = stainObjects.Length;

        UpdateCounts();
    }

    public void IncreaseStainCount()
    {
        staincount++;
    }

    public void UpdateCounts()
    {
        staincountText.text = staincount.ToString() + "/" + staingameObject.ToString();
    }
}
