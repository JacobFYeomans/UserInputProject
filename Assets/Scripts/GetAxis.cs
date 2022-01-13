using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{

    //public float speed = 10.0f;
    //float movementX = Input.GetAxis("Horizontal");
    //float movementY = Input.GetAxis("Vertical");

    public float horizontalSpeed = 2.0f;
    public float verticalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = (horizontalSpeed * Time.deltaTime) * Input.GetAxis("Mouse Y");
        float h = (verticalSpeed * Time.deltaTime) * Input.GetAxis("Mouse X");
        transform.Translate(h, 0, v);
    }
}
