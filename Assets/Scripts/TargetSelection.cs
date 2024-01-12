using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelection : MonoBehaviour
{
    private MeshRenderer rend;

    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    private void OnMouseEnter()
    {
        if (this.gameObject.tag == "trash")
        {
            Debug.Log("Red");
            rend.material.color = Color.red;
        }

        else if (this.gameObject.tag == "stain")
        {
            Debug.Log("Yellow");
            rend.material.color = Color.yellow;
        }
    }

    private void OnMouseExit()
    {
        rend.material.color = Color.white;
    }
}
