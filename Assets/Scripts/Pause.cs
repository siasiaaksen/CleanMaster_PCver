using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool isPause = false;
    public GameObject Panel;
    public Transform buttonScale;
    Vector3 defaultScale;
    private CameraMove cameraMoveScript; // 추가: FirstPersonCamera 스크립트 참조 변수

    void Start()
    {
        defaultScale = buttonScale.localScale;
        cameraMoveScript = FindObjectOfType<CameraMove>(); // 추가: FirstPersonCamera 스크립트 찾기
    }

    void Update()
    {
        pausePanel();
        // Countinue();
        // GoToMain();
    }

    void pausePanel()
    {
        if (Input.GetKeyDown("p"))
        {
            isPause = !isPause;
            if (isPause)
            {
                Time.timeScale = 0;
                Panel.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                // cameraMoveScript.StopCam(); // 추가: StopCam 함수 호출
            }
            else
            {
                Time.timeScale = 1;
                Panel.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }

    public void Countinue()
    {
        isPause = false;
        Panel.SetActive(false);
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("01_Main");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonScale.localScale = defaultScale;
    }
}
