using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStab : MonoBehaviour
{
    public bool hasSwung;
    public GameObject attackBox;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        attackBox.SetActive(false);
        hasSwung = false;

        anim = attackBox.GetComponent<Animator>();
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
        attackBox.SetActive(true);
        anim.SetBool("swung", true);
        yield return new WaitForSeconds(0.5f);
        attackBox.SetActive(false);
        anim.SetBool("swung", false);
        yield return new WaitForSeconds(0.7f);
        hasSwung = false;
    }
}
