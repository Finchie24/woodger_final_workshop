using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Cancel"))
        {
            Application.Quit();
        }
    }
}
