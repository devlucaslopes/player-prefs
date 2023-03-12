using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();

            player.Respawn();
        }
    }
}
