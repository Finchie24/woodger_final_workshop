using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public float doorNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (doorNumber == 1) { StartingStats.start = new Vector3(-0.9f, 13f, 0f); SceneManager.LoadScene(3); }
            if (doorNumber == 2) { StartingStats.start = new Vector3(-26.2f, 0.1f, 0f); SceneManager.LoadScene(3); }
            if (doorNumber == 3) { StartingStats.start = new Vector3(-26.4f, 0.1f, 0f); SceneManager.LoadScene(4); }
            if (doorNumber == 4) { StartingStats.start = new Vector3(-1.1f, -12.6f, 0f); SceneManager.LoadScene(2); }
            if (doorNumber == 5) { StartingStats.start = new Vector3(-26.3f, 0.4f, 0f); SceneManager.LoadScene(6); }
            if (doorNumber == 6) { StartingStats.start = new Vector3(-26.3f, 0f, 0f); SceneManager.LoadScene(7); }
            if (doorNumber == 7) { StartingStats.start = new Vector3(-0.8f, 12.9f, 0f); SceneManager.LoadScene(8); }
            if (doorNumber == 8) { StartingStats.start = new Vector3(-0.9f, 13.3f, 0f); SceneManager.LoadScene(9); }
            if (doorNumber == 9) { StartingStats.start = new Vector3(-0.7f, 13.2f, 0f); SceneManager.LoadScene(10); }
            if (doorNumber == 10) { StartingStats.start = new Vector3(-26.5f, 0.2f, 0f); SceneManager.LoadScene(9); }
            if (doorNumber == 11) { StartingStats.start = new Vector3(-26.5f, 0.3f, 0f); SceneManager.LoadScene(10); }
            if (doorNumber == 12) { StartingStats.start = new Vector3(-1, 12.7f, 0f); SceneManager.LoadScene(11); }
            if (doorNumber == 13) { StartingStats.start = new Vector3(-1f, -13.2f, 0f); SceneManager.LoadScene(1); }
            if (doorNumber == 14) { StartingStats.start = new Vector3(25.8f, 0.1f, 0f); SceneManager.LoadScene(2); }
            if (doorNumber == 15) { StartingStats.start = new Vector3(26.5f, 01f, 0f); SceneManager.LoadScene(3); }
            if (doorNumber == 16) { StartingStats.start = new Vector3(-0.7f, 13.5f, 0f); SceneManager.LoadScene(7); }
            if (doorNumber == 17) { StartingStats.start = new Vector3(-0.9f, -12.8f, 0f); SceneManager.LoadScene(4); }
            if (doorNumber == 18) { StartingStats.start = new Vector3(-0.9f, 12.6f, 0f); SceneManager.LoadScene(5); }
            if (doorNumber == 19) { StartingStats.start = new Vector3(26.4f, 0.3f, 0f); SceneManager.LoadScene(5); }
            if (doorNumber == 20) { StartingStats.start = new Vector3(26.3f, 0.3f, 0f); SceneManager.LoadScene(6); }
            if (doorNumber == 21) { StartingStats.start = new Vector3(-0.8f, -13.5f, 0f); SceneManager.LoadScene(7); }
            if (doorNumber == 22) { StartingStats.start = new Vector3(26.6f, 0.2f, 0f); SceneManager.LoadScene(9); }
            if (doorNumber == 23) { StartingStats.start = new Vector3(26.7f, 0.3f, 0f); SceneManager.LoadScene(8); }
            if (doorNumber == 24) { StartingStats.start = new Vector3(-0.9f, -13.4f, 0f); SceneManager.LoadScene(6); }
            if (doorNumber == 25) { StartingStats.start = new Vector3(-0.9f, -13.2f, 0f); SceneManager.LoadScene(5); }
            if (doorNumber == 26) { StartingStats.start = new Vector3(-1, -13.3f, 0f); SceneManager.LoadScene(9); }
        }
    }
}
