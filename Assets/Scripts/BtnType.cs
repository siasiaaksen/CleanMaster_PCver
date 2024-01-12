using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup DevGroup;
    public CanvasGroup GameGroup;
    public CanvasGroup HTPGroup;
    public CanvasGroup InfoGroup;
    public CanvasGroup SWGroup;
    public CanvasGroup SPGroup;
    public CanvasGroup StoryGroup;
    public CanvasGroup LevelGroup;
    public CanvasGroup HTPinGroup;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    bool isSound;

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.New1:
                SceneLoad.LoadSceneHandle("Lv.1", 0);
                break;
            case BTNType.New2:
                SceneLoad.LoadSceneHandle("Lv.2", 0);
                break;
            case BTNType.Continue1:
                SceneLoad.LoadSceneHandle("Lv.1", 1);
                break;
            case BTNType.Continue2:
                SceneLoad.LoadSceneHandle("Lv.2", 1);
                break;
            case BTNType.DevOption:
                CanvasGroupOn(InfoGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.GameOption:
                CanvasGroupOn(GameGroup);
                CanvasGroupOff(mainGroup);
                break;
            case BTNType.HTPOption:
                CanvasGroupOn(StoryGroup);
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
            case BTNType.DevBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(SPGroup);
                break;
            case BTNType.GameBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(GameGroup);
                break;
            case BTNType.HTPBack:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(HTPinGroup);
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
            case BTNType.InfoNext:
                CanvasGroupOn(SWGroup);
                CanvasGroupOff(InfoGroup);
                break;
            case BTNType.SWPrev:
                CanvasGroupOn(InfoGroup);
                CanvasGroupOff(SWGroup);
                break;
            case BTNType.SWNext:
                CanvasGroupOn(SPGroup);
                CanvasGroupOff(SWGroup);
                break;
            case BTNType.SPPrev:
                CanvasGroupOn(SWGroup);
                CanvasGroupOff(SPGroup);
                break;
            // case BTNType.SPNext:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            // case BTNType.StoryPrev:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            case BTNType.StoryNext:
                CanvasGroupOn(LevelGroup);
                CanvasGroupOff(StoryGroup);
                break;
            case BTNType.LevelPrev:
                CanvasGroupOn(StoryGroup);
                CanvasGroupOff(LevelGroup);
                break;
            case BTNType.LevelNext:
                CanvasGroupOn(HTPinGroup);
                CanvasGroupOff(LevelGroup);
                break;
            case BTNType.HTPinPrev:
                CanvasGroupOn(LevelGroup);
                CanvasGroupOff(HTPinGroup);
                break;
            // case BTNType.HTPinNext:
            //     CanvasGroupOn();
            //     CanvasGroupOff();
            //     break;
            case BTNType.Quit:
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

    public void OnSelect(BaseEventData eventData)
    {
        buttonScale.localScale = defaultScale * 1.1f;
    }
}