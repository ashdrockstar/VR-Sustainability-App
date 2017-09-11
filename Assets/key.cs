using UnityEngine;
using System.Collections;

public class key : MonoBehaviour {

    public float Speed;

    private Vector3 tempPosition;

    void Start()
    {
        tempPosition = transform.position;
    }

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            tempPosition.x -= Speed;
            transform.position = tempPosition;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            tempPosition.x -= Speed;
            tempPosition.z -= Speed;
            transform.position = tempPosition;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            tempPosition.x += Speed;
            tempPosition.z += Speed;
            transform.position = tempPosition;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            tempPosition.x += Speed;
            transform.position = tempPosition;
        }

    }
}
