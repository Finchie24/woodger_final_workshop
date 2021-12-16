using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public SpriteRenderer sprite;
    public bool cooldown = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Projectile") && cooldown == false)
        {
            StartingStats.health -= 1;
            StartCoroutine(Hit());
            Debug.Log("You got hurt, your health is now " + StartingStats.health);
        }
        if (StartingStats.health == 0)
        {
            SceneManager.LoadScene(12);
            Debug.Log("You died");
        }
        if (other.gameObject.CompareTag("Health"))
        {
            Destroy(other.gameObject);
            if (StartingStats.health < 10)
            {
                StartingStats.health += 1;
            }
        }
    }

    IEnumerator Hit()
    {
        sprite.color = Color.red;
        cooldown = true;
        yield return new WaitForSeconds(0.3f);
        cooldown = false;
        sprite.color = Color.white;
    }
}
