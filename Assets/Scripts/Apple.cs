using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] float xLimit = 16.0f;
    [SerializeField] float yLimit = 8.5f;

    private void Start()
    {
        transform.position = new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent.GetComponent<Player>().AddTail();

            transform.position = new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit), 0);
        }
    }
}
