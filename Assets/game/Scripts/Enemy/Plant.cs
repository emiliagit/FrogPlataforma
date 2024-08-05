using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Plant : EnemyPadre
{
    //private Transform player;

    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float fireRate = 1f;
    private float nextFireTime = 0f;
    public float bulletForce = 7f;

    public float projectileSpeed = 10f;


    private void Start()
    {
        
        //player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {

            if (Time.time >= nextFireTime)
            {
                Attack();
                nextFireTime = Time.time + 1f / fireRate;
            }
        

    }

    protected override void Attack()
    {
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        // Asignar velocidad al proyectil
        ProyectilePlant projectileScript = projectile.GetComponent<ProyectilePlant>();
        if (projectileScript != null)
        {
            projectileScript.speed = projectileSpeed;
        }
    }

    //private void AttackPlayer()
    //{
        

    //}

    
}
