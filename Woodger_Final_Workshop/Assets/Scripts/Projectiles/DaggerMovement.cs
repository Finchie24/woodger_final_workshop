using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerMovement : MonoBehaviour
{
    private float speed = 17f;

    private void Start()
    {
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
