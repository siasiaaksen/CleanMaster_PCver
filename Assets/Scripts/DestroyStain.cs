using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStain : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cleaner")
        {
            if (gameObject.tag == "stain")
            {
                // TrashCount 스크립트가 있는 TrashCan 오브젝트 찾기
                StainCount stainCountScript = collision.gameObject.GetComponent<StainCount>();

                // TrashCount 스크립트가 있다면 trashcount를 증가시키고 UpdateCounts 함수 호출
                if (stainCountScript != null)
                {
                    stainCountScript.IncreaseStainCount();
                    stainCountScript.UpdateCounts();
                }

                // Trash 오브젝트 파괴
                Destroy(gameObject);
            }
        }
    }
}
