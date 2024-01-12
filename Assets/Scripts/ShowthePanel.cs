using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class ShowthePanel : MonoBehaviour
{
    public GameObject objectCount;
    public GameObject successCanvas;
    public GameObject empty;
    // private CameraMove cameraMoveScript; // 추가: FirstPersonCamera 스크립트 참조 변수

    void Start()
    {
        // cameraMoveScript = FindObjectOfType<CameraMove>(); // 추가: FirstPersonCamera 스크립트 찾기
    }

    void Update()
    {
        if (objectCount != null && objectCount.transform.childCount == 1)
        {
            Destroy(empty, 1f);
        }

        if (objectCount != null && objectCount.transform.childCount == 0)
        {
            successCanvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            // cameraMoveScript.StopCam(); // 추가: StopCam 함수 호출
        }
    }
}
