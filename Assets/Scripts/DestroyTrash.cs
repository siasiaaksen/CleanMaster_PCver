using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyTrash : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트의 태그가 'TrashCan'인지 확인
        if (collision.gameObject.tag == "TrashCan")
        {
            // 충돌한 오브젝트의 태그가 'trash'이면 파괴(사라지게)함
            if (gameObject.tag == "trash")
            {
                // TrashCount 스크립트가 있는 TrashCan 오브젝트 찾기
                TrashCount trashCountScript = collision.gameObject.GetComponent<TrashCount>();

                // TrashCount 스크립트가 있다면 trashcount를 증가시키고 UpdateCounts 함수 호출
                if (trashCountScript != null)
                {
                    trashCountScript.IncreaseTrashCount();
                    trashCountScript.UpdateCounts();
                }

                // Trash 오브젝트 파괴
                Destroy(gameObject);
            }
        }
    }
}

