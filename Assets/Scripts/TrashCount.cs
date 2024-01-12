using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCount : MonoBehaviour
{
    public TextMeshProUGUI trashcountText;
    public int trashcount = 0;
    public int trashgameObject;

    void Start()
    {
        GameObject[] trashObjects = GameObject.FindGameObjectsWithTag("trash");
        trashgameObject = trashObjects.Length;

        UpdateCounts();
    }

    public void IncreaseTrashCount()
    {
        trashcount++;
    }

    public void UpdateCounts()
    {
        trashcountText.text = trashcount.ToString() + "/" + trashgameObject.ToString();
    }
}


