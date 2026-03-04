using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("This is a START event")

        // int wholeNumber = three
        // float fractionalNumber = -627.52f;

        // bool isCold = false;

        // string words = "Hello, World";

        // Color blue = new Color(0f, of, 1f, 0.5f)
        // Vector2 location = new Vector2(-2.5f, 6f);
        // Vector3 direction = new Vector3(-3.5f, 2, 5.4f)
    }

    // Update is called once per frame
    void Update()
    {
        // Move Up
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0, 0.2f, 0);
        }

        // Move Down
        if(Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0, -0.2f, 0);
        }

        // Move Left
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-0.2f, 0, 0);
        }

        // Move Right
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(0.2f, 0, 0);
        }
    }
}
