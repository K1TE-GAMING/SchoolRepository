using UnityEngine;

public class Would : MonoBehaviour
{
    private float speed = 5.0f;
    void Start()
    {
        Destroy(gameObject, 5.0f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
