using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject HTP;

    public void ShowHTPPanel()
    {
        HTP.SetActive(true);
    }

    public void HideHTPPanel()
    {
        HTP.SetActive(false);
    }
}
