using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonScript : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hurts"))
        {
            Debug.Log("Skeleton Got Smacked");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 diff = player.transform.position - transform.position;

        float angle = Mathf.Atan2(diff.y, diff.x);

        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);

        //transform.LookAt(player.transform);
    }
}
