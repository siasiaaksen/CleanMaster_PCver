using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        // 앞으로 이동
        if (Input.GetKey("w"))
        {
            Debug.Log("KeyCheck: W");

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // 뒤로 이동
        if (Input.GetKey("s"))
        {
            Debug.Log("KeyCheck: S");

            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        // 좌로 이동
        if (Input.GetKey("a"))
        {
            Debug.Log("KeyCheck: A");

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // 우로 이동
        if (Input.GetKey("d"))
        {
            Debug.Log("KeyCheck: D");

            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
