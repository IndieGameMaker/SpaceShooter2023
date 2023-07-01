using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A, D , Left Arrow, Right Arrow // -1.0f ~ 0.0f ~ +1.0f
        float v = Input.GetAxis("Vertical"); // W, S, Up, Down // -1.0f ~ 0.0f ~ +1.0f

        Debug.Log("h=" + h);
        Debug.Log("v=" + v);
    }
}
