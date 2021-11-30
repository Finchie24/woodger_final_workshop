using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    /*private bool pressedA;
    private bool pressedD;
    private bool pressedS;
    private bool pressedW;*/

    public GameObject attackBox;
    public new Transform transform;
    public Camera cam;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        /*pressedA = false;
        pressedD = false;
        pressedS = false;
        pressedW = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 lookDir = mousePos - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
