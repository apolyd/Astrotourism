using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;
public class GunScript : MonoBehaviour
{
    public GameObject Bullet;
    public ParticleSystem MuzzleEffect;
    public Transform BarrelPivot;
    public float ShootingSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void Fire()
    {
        //Debug.Log("Fire");
        Rigidbody BulletRb = Instantiate(Bullet, BarrelPivot.position, BarrelPivot.rotation).GetComponent<Rigidbody>();
        BulletRb.velocity = BarrelPivot.forward * ShootingSpeed;
        MuzzleEffect.Play();
    }
}
