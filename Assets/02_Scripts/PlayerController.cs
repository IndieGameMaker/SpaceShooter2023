using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform tr;

    [SerializeField]
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    // A PC 100f , B PC 50f
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A, D , Left Arrow, Right Arrow // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical"); // W, S, Up, Down // -1.0f ~ 0.0f ~ +1.0f

        //tr.position += new Vector3(0, 0, 0.1f); // tr.position = tr.position + new Vector3(0, 0, 0.1f);
        //tr.position += Vector3.forward * 0.1f;

        // 방향벡터를 연산 
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir.normalized * Time.deltaTime * 5.0f);

        //tr.Translate(Vector3.forward * 0.1f * v);
        //tr.Translate(Vector3.right * 0.1f * h);

        Debug.Log("h=" + h);
        Debug.Log("v=" + v);
    }
}
