using UnityEngine;
using UnityEngine.Animations;


public class Raccon_shoot : MonoBehaviour
{

    public BulletBehaviour bulletPrefab;
    public Transform firePoint;

    private PlayerInputhanddle inputHandler;


    private void Awake()
    {
        inputHandler = GetComponent<PlayerInputhanddle>();

    }

    void Update()
    {
        AimToMouse();

        if (inputHandler.ShootPressed)
        {
            Shoot();
        }
    }

    void AimToMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(inputHandler.AimInput);
        mousePosition.z = 0f;

        Vector3 direction = (mousePosition - firePoint.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        firePoint.rotation = Quaternion.Euler(0f, 0f, angle);

    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

}
