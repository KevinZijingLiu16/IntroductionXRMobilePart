using UnityEngine;

public class UIScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = player.transform.position;
    }

    public void ResetButton()
    {
        player.transform.position = startPosition;
    }
}
