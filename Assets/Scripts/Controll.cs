using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    [SerializeField] Bullet _bullet;
    [SerializeField] Transform _startBullet;

    private void Start()
    {
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Fire();
        
    }

    void Fire()
    {
        GetComponent<AudioSource>().Play();
        Bullet bull = Instantiate(_bullet, _startBullet.position, _startBullet.rotation);
        bull.Launch(transform.localScale.x);
    }

 
}
