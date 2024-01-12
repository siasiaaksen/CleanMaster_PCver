using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType1 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType1 currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup DevGroup;
    public CanvasGroup GameGroup;
    public CanvasGroup HTPGroup;
    // public CanvasGroup InfoGroup;
    // public CanvasGroup SWGroup;
    // public CanvasGroup SPGroup;
    // public CanvasGroup StoryGroup;
    // public CanvasGroup LevelGroup;
    // public CanvasGroup HTPinGroup;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    // bool isSound;

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType1.New1:
                // SceneLoad.LoadSceneHandle("02_House", 0);
                SceneManager.LoadScene("02_House");
                break;
            case BTNType1.New2:
                // SceneLoad.LoadSceneHandle("03_Office", 0);
                SceneManager.LoadScene("03_Office");
                break;
            case BTNType1.Continue1:
                SceneLoad.LoadSceneHandle("house_locate_set", 1);
                break;
            case BTNType1.Continue2:
                SceneLoad.LoadSceneHandle("OFFICE_Sample", 1);
                break;
            case BTNType1.DevOption:
                CanvasGroupOn(DevGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType1.GameOption:
                CanvasGroupOn(GameGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType1.HTPOption:
                CanvasGroupOn(HTPGroup);
                CanvasGroupOff(mainGroup);
                break;
            // case BTNType.InfoOption:
            //     CanvasGroupOn(InfoGroup);
            //     CanvasGroupOff(DevGroup);
            //     break;
            // case BTNType.SWOption:
            //     CanvasGroupOn(SWGroup);
            //     CanvasGroupOff(DevGroup);
            //     break;
            // case BTNType.SPOption:
            //     CanvasGroupOn(SPGroup);
            //     CanvasGroupOff(DevGroup);
            //     break;
            // case BTNType.StoryOption:
            //     CanvasGroupOn(StoryGroup);
            //     CanvasGroupOff(HTPGroup);
            //     break;
            // case BTNType.LevelOption:
            //     CanvasGroupOn(LevelGroup);
            //     CanvasGroupOff(HTPGroup);
            //     break;
            // case BTNType.HTPinOption:
            //     CanvasGroupOn(HTPinGroup);
            //     CanvasGroupOff(HTPGroup);
            //     break;
            // case BTNType.Sound:
            //     if (isSound)
            //     {
            //         isSound = !isSound;
            //         Debug.Log("사운드OFF");
            //     }
            //     else
            //     {
            //         Debug.Log("사운드ON");
            //     }
            //     isSound = !isSound;
            //     break;
            case BTNType1.DevBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(DevGroup);
                break;
            case BTNType1.GameBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(GameGroup);
                break;
            case BTNType1.HTPBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(HTPGroup);
                break;
            // case BTNType.InfoBack:
            //     CanvasGroupOn(DevGroup);
            //     CanvasGroupOff(InfoGroup);
            //     break;
            // case BTNType.SWBack:
            //     CanvasGroupOn(DevGroup);
            //     CanvasGroupOff(SWGroup);
            //     break;
            // case BTNType.SPBack:
            //     CanvasGroupOn(DevGroup);
            //     CanvasGroupOff(SPGroup);
            //     break;
            // case BTNType.StoryBack:
            //     CanvasGroupOn(HTPGroup);
            //     CanvasGroupOff(StoryGroup);
            //     break;
            // case BTNType.LevelBack:
            //     CanvasGroupOn(HTPGroup);
            //     CanvasGroupOff(LevelGroup);
            //     break;
            // case BTNType.HTPinBack:
            //     CanvasGroupOn(HTPGroup);
            //     CanvasGroupOff(HTPinGroup);
            //     break;
            // case BTNType.InfoPrev:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            // case BTNType.InfoNext:
            //     CanvasGroupOn(SWGroup);
            //     CanvasGroupOff(InfoGroup);
            //     break;
            // case BTNType.SWPrev:
            //     CanvasGroupOn(InfoGroup);
            //     CanvasGroupOff(SWGroup);
            //     break;
            // case BTNType.SWNext:
            //     CanvasGroupOn(SPGroup);
            //     CanvasGroupOff(SWGroup);
            //     break;
            // case BTNType.SPPrev:
            //     CanvasGroupOn(SWGroup);
            //     CanvasGroupOff(SPGroup);
            //     break;
            // case BTNType.SPNext:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            // case BTNType.StoryPrev:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            // case BTNType.StoryNext:
            //     CanvasGroupOn(LevelGroup);
            //     CanvasGroupOff(StoryGroup);
            //     break;
            // case BTNType.LevelPrev:
            //     CanvasGroupOn(StoryGroup);
            //     CanvasGroupOff(LevelGroup);
            //     break;
            // case BTNType.LevelNext:
            //     CanvasGroupOn(HTPinGroup);
            //     CanvasGroupOff(LevelGroup);
            //     break;
            // case BTNType.HTPinPrev:
            //     CanvasGroupOn(LevelGroup);
            //     CanvasGroupOff(HTPinGroup);
            //     break;
            // case BTNType.HTPinNext:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            case BTNType1.Quit:
                Application.Quit();
                Debug.Log("앱종료");
                break;
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
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