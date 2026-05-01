using NUnit.Framework.Interfaces;
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

            //if bullet hits brick wall, destroy bullet and brick wall
                if (gameObject.CompareTag("Bullet") && other.CompareTag("Brick Wall"))
                {
                    Destroy(gameObject);
                    Destroy(other.gameObject);
                }

            //of bullet hits steel wall, destroy bullet but not steel wall
                if (gameObject.CompareTag("Bullet") && other.CompareTag("Steel Wall"))
                {
                    Destroy(gameObject);
                }

        //if bullet hits Tank, destroy bullet and destroy Tank
                if (gameObject.CompareTag("Bullet") && other.CompareTag("Tank"))
                {
                    Destroy(gameObject);
                    Destroy(other.gameObject);
                }

        //if Raccon touch tank, destroy raccoon
                if (gameObject.CompareTag("Raccon") && other .CompareTag("Tank"))
                {
                    Destroy(gameObject);
                }
    }
 
}
