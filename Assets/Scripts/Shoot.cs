using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] float bulletForce = 5f;
    PlayerController _playercontroller;  

    // Start is called before the first frame update
    void Start()
    {
        _playercontroller = GetComponent<PlayerController>();
    }

    void ShootBullet()
    {
        GameObject shuriken = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = shuriken.GetComponent<Rigidbody2D>();
        firePoint.transform.localPosition = new Vector3(0f, 0f, 0.5f);
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
            
        }
    }
}
