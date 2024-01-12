using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class UseTool : MonoBehaviour
{
    public Image hand;
    // public Image cloth;
    public Image vacuum;

    Vector3 defaultScale;

    public GameObject H_Check;
    // public GameObject C_Check;
    public GameObject V_Check;
    public GameObject Hands;
    public GameObject Vacuum;

    public GameObject pickupPos;
    private GameObject pickedObj;

    public Camera cam;

    private bool isPickup = false;

    void Start()
    {
        defaultScale = hand.rectTransform.localScale;
        // defaultScale = cloth.rectTransform.localScale;
        defaultScale = vacuum.rectTransform.localScale;

        pickupPos = GameObject.Find("PickupPos");
        
        Vacuum.SetActive(true);
        V_Check.SetActive(true);
    }

    void Update()
    {
        SelectHand();
        // SelectCloth();
        SelectVacuum();
        PickUp();
    }

    void SelectHand()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("KeyCheck: 1");
            hand.rectTransform.localScale = defaultScale * 1.1f;
            H_Check.SetActive(true);
            Hands.SetActive(true);

            isPickup = true;
        }
        else if (Input.GetKeyDown("2"))
        {
            hand.rectTransform.localScale = defaultScale;
            H_Check.SetActive(false);
            Hands.SetActive(false);
        }
    }

    // void SelectCloth()
    // {
    //     if (Input.GetKey("2"))
    //     {
    //         Debug.Log("KeyCheck: 2");
    //         cloth.rectTransform.localScale = defaultScale * 1.1f;
    //         C_Check.SetActive(true);

    //         isPickup = false;

    //         if (pickedObj != null)
    //         {
    //             // If there are child objects, disable key 2 and 3
    //             DisableKeys2And3();
    //         }
    //         else
    //         {
    //             // If there are no child objects, revert to original state
    //             PickUp();
    //         }
    //     }
    //     else if (Input.GetKey("1") || Input.GetKey("3"))
    //     {
    //         cloth.rectTransform.localScale = defaultScale;
    //         C_Check.SetActive(false);
    //     }
    // }

    void SelectVacuum()
    {
        if (Input.GetKeyDown("2"))
        {
            Debug.Log("KeyCheck: 2");
            vacuum.rectTransform.localScale = defaultScale * 1.1f;
            V_Check.SetActive(true);
            Vacuum.SetActive(true);

            isPickup = false;

            if (pickedObj != null)
            {
                // If there are child objects, disable key 2 and 3
                DisableKey2();
            }
            else
            {
                // If there are no child objects, revert to original state
                PickUp();
            }
        }
        else if (Input.GetKeyDown("1"))
        {
            vacuum.rectTransform.localScale = defaultScale;
            V_Check.SetActive(false);
            Vacuum.SetActive(false);
        }
    }

    void PickUp()
    {
        if (isPickup == true)
        {
            //마우스 버튼 클릭 시 쓰레기 줍기
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Click");
                
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out RaycastHit trash))
                {
                    if (trash.collider.gameObject.CompareTag("trash"))
                    {
                        trash.collider.gameObject.transform.parent = pickupPos.transform;
                        trash.collider.gameObject.transform.position = pickupPos.transform.position;
                        pickedObj = pickupPos.transform.GetChild(0).gameObject;
                        Debug.Log("pickedObj: " + pickedObj);
                    }
                }
            }
        }
    }

    void DisableKey2()
    {
        // key 2 and 3 are disabled when pickedObj exists
        hand.rectTransform.localScale = defaultScale * 1.1f;
        H_Check.SetActive(true);
        Hands.SetActive(true);
        // cloth.rectTransform.localScale = defaultScale;
        // C_Check.SetActive(false);
        vacuum.rectTransform.localScale = defaultScale;
        V_Check.SetActive(false);
        Vacuum.SetActive(false);
    }
}
