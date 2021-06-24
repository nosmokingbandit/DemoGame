using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Rigidbody Cube;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press L to rotate camera");
        Debug.Log("Press M to move cube");
        Debug.Log("Press S to stop cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(new Vector3(0, 45, 0), Space.World);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Cube.AddForce(new Vector3(5, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Cube.velocity = Vector3.zero;
        }
    }
}
