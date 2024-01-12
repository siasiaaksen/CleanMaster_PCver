using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMainPanel : MonoBehaviour
{
    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;

    public void ShowFirstPanelLeft()
    {
        secondPanel.SetActive(false);
        firstPanel.SetActive(true);
    }

    public void ShowSecondPanelRight()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
    }

    public void ShowSecondPanelLeft()
    {
        thirdPanel.SetActive(false);
        secondPanel.SetActive(true);
    }

    public void ShowThirdPanelRight()
    {
        secondPanel.SetActive(false);
        thirdPanel.SetActive(true);
    }
}
