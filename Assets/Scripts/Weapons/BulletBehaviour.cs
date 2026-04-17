using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletLifetime = 5f;

    void Update()
    {
        transform.position += transform.right * bulletSpeed * Time.deltaTime;

        destroyBullet();
    }

    void destroyBullet()
    {
        if (bulletLifetime <= 0f)
        {
            Destroy(gameObject);
        }
        else
        {
            bulletLifetime -= Time.deltaTime;
        }
    }
}
