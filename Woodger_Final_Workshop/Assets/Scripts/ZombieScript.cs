using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public GameObject brainPrefab;
    public GameObject player;
    public int hp = 3;
    public bool pew;

    private void Start()
    {
        pew = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hurts"))
        {
            hp -= 1;
        }
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = player.transform.position - transform.position;

        float angle = Mathf.Atan2(diff.y, diff.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);

        transform.Translate(Vector3.up * Time.deltaTime * 0.5f);

        if (!pew)
        {
            pew = true;
            StartCoroutine(Blam());
        }
    }

    IEnumerator Blam()
    {
        Instantiate(brainPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(4f);
        pew = false;
    }
}
