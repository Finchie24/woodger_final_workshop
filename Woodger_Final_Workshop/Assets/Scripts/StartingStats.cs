using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingStats : MonoBehaviour
{
    static public float health;
    static public Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        start = new Vector3(-2f, 12.9f, 0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
