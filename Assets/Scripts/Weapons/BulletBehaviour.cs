using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float bulletSpeed = 10f;

    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
    }
}
