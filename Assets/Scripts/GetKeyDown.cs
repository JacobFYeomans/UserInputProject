using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDown : MonoBehaviour
{
    public float movement = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyDown("w"))
        {
            pos.z += movement;
        }
        if (Input.GetKeyDown("s"))
        {
            pos.z -= movement;
        }
        if (Input.GetKeyDown("d"))
        {
            pos.x += movement;
        }
        if (Input.GetKeyDown("a"))
        {
            pos.x -= movement;
        }

        transform.position = pos;
    }
}
