using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStab : MonoBehaviour
{
    public GameObject Sword;
    public bool hasSwung;

    // Start is called before the first frame update
    void Start()
    {
        Sword.SetActive(false);
        hasSwung = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasSwung)
        {
            StartCoroutine(SwingTimer());
            hasSwung = true;
        }
    }

    IEnumerator SwingTimer()
    {
        Sword.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Sword.SetActive(false);
        yield return new WaitForSeconds(0.7f);
        hasSwung = false;
    }
}
