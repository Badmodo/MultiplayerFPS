using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunOldFPS : MonoBehaviour
{
    public float damage = 10f;
    public float range = 200f;
    public float fireRate = 20f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlashL;
    public ParticleSystem muzzleFlashR;
    public GameObject impactEffect;
    public CameraShake cameraShake;

    private float NextTimToFire = 0f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= NextTimToFire)
        {
            NextTimToFire = Time.time + 1f / fireRate;
            ShootLeft();
        } 
        if (Input.GetButtonDown("Fire2") && Time.time >= NextTimToFire)
        {
            NextTimToFire = Time.time + 1f / fireRate;
            ShootRight();
        }
    }

    void ShootLeft()
    {
        muzzleFlashL.Play();

        StartCoroutine(cameraShake.Shake(.15f, .4f));

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
    void ShootRight()
    {
        muzzleFlashR.Play();

        StartCoroutine(cameraShake.Shake(.15f, .4f));

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
