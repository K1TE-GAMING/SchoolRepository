using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float bulletSpeed = 10f;

    void Update()
    {
        transform.position += -transform.right * bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy the bullet depending on the weakness of the object it collides with

        //Destroy the fire bullet if it collides with a water object
        if(gameObject.CompareTag("FireBullet") && collision.gameObject.CompareTag("Water"))
        {
            Destroy(gameObject);
        }


        //Destroy the water bullet if it collides with a Grass object
        if(gameObject.CompareTag("WaterBullet") && collision.gameObject.CompareTag("Grass"))
        {
            Destroy(gameObject);
        }


        //Destory Grass bullet if it collides with a fire object
        if(gameObject.CompareTag("GrassBullet") && collision.gameObject.CompareTag("Fire"))
        {
            Destroy(gameObject);
        }

    }
}
