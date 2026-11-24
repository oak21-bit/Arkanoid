using UnityEngine;

public class quebrar : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bola"))
        {
            Destroy(gameObject);
        }
    }
}
