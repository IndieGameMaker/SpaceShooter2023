using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            Destroy(coll.gameObject);
        }

        // if (coll.collider.tag == "BULLET")
        // {
        // }
    }
}


/*
    충돌 콜백함수(메소드) / 이벤트 함수

    # Collider 컴포넌트의 IsTrigger 언체크

    OnCollisionEnter - 1 호출
    OnCollisionStay  - n 호출 (0.02 sec)
    OnCollisionExit  - 1 호출

    # Collider 컴포넌트의 IsTrigger 체크

    OnTriggerEnter
    OnTriggerStay
    OnTriggerExit



    # 충돌 콜백함수가 호출되는 조건

    1 조건 : 양쪽 다 Collider 컴포넌트가 있어야 함.
    2 조건 : 이동하는 객체에는 반드시 Rigidbody 컴포넌트가 있어야 함.
*/