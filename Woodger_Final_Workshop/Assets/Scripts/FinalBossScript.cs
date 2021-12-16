using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBossScript : MonoBehaviour
{
    public GameObject lightningPrefab;
    public GameObject player;
    public int hp = 5;
    public bool pew;

    private float xRange = 26;
    private float yRange = 13;

    public SpriteRenderer sprite;

    private void Start()
    {
        pew = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hurts"))
        {
            hp -= 1;
            StartCoroutine(Hit());
        }
        if (hp == 0)
        {
            StartCoroutine(EndGame());
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = player.transform.position - transform.position;

        float angle = Mathf.Atan2(diff.y, diff.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);

        transform.Translate(Vector3.right * Time.deltaTime * 3);

        if (!pew)
        {
            pew = true;
            StartCoroutine(Blam());
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }
    }

    IEnumerator Blam()
    {
        yield return new WaitForSeconds(0.7f);
        Instantiate(lightningPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(2.7f);
        pew = false;
    }

    IEnumerator EndGame()
    {
        Debug.Log("yay");
        SceneManager.LoadScene(13);
        yield return null;
    }

    IEnumerator Hit()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprite.color = Color.white;
    }
}
