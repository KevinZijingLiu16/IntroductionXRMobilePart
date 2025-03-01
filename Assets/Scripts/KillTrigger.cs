using UnityEngine;

public class KillTrigger : MonoBehaviour
{

    [SerializeField] private GameObject player;
    private Vector2 playerSpawnPoint;


    private void Start()
    {
        playerSpawnPoint = player.transform.position;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            player.transform.position = playerSpawnPoint;
        }
    }
}

