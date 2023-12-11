using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOAL1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            TeleportPlayer();
            
            SceneManager.LoadScene("Level 2");
        }
    }

    private void TeleportPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        player.transform.position = new Vector3(0f, 1f, 0f); // Adjust the position accordingly
    }
}
