using UnityEngine;

public class Weakness : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Fire") && other.CompareTag("Water"))
        {
            Destroy(gameObject);
        }

            if (gameObject.CompareTag("Water") && other.CompareTag("Grass"))
            {
                Destroy(gameObject);
            }
    
            if (gameObject.CompareTag("Grass") && other.CompareTag("Fire"))
            {
                Destroy(gameObject);
        }
    }
}
