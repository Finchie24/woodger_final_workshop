using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : MonoBehaviour
{
    public GameObject daggerPrefab;
    public GameObject player;
    public int hp = 1;
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

        transform.Translate(Vector3.up * Time.deltaTime * 2.5f);

        if (!pew)
        {
            pew = true;
            StartCoroutine(Blam());
        }
    }

    IEnumerator Blam()
    {
        Instantiate(daggerPrefab, transform.position, transform.rotation);
        yield return new WaitForSeconds(4f);
        pew = false;
    }
}
