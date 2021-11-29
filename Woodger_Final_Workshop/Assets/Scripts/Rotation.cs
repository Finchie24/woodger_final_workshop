using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private bool pressedA;
    private bool pressedD;
    private bool pressedS;
    private bool pressedW;

    // Start is called before the first frame update
    void Start()
    {
        pressedA = false;
        pressedD = false;
        pressedS = false;
        pressedW = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pressedA && (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(0, 0, 90);
            pressedA = true;
            pressedD = false;
            pressedS = false;
            pressedW = false;
        }
        if (!pressedD && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(0, 0, 270);
            pressedA = false;
            pressedD = true;
            pressedS = false;
            pressedW = false;
        }
        if (!pressedS && (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(0, 0, 180);
            pressedA = false;
            pressedD = false;
            pressedS = true;
            pressedW = false;
        }
        if (!pressedW && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(0, 0, 00);
            pressedA = false;
            pressedD = false;
            pressedS = false;
            pressedW = true;
        }
    }
}
