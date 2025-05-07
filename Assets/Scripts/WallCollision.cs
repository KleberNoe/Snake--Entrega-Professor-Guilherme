using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager gameManeger = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManeger.GameOver();
        }
    }
}
