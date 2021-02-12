using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private float speed;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * (-speed) * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.forward * (speed) * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.right * (speed) * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * (-speed) * Time.deltaTime;
        }
    }
}
