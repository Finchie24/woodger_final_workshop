using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningMovement : MonoBehaviour
{
    private float speed = 25f;

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
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
