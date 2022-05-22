using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] AudioClip shotsound;
    AudioSource _audiosource;
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField] float bulletForce = 5f;
    PlayerController _playercontroller;  
    GameObject bullet;
    

    // Start is called before the first frame update
    void Start()
    {
        _playercontroller = GetComponent<PlayerController>();
        _audiosource = GetComponent<AudioSource>();
    }

    void ShootBullet()
    {
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        _audiosource.PlayOneShot(shotsound, 0.5f);
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
