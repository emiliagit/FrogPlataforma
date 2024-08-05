using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilePlant : MonoBehaviour
{

    public Animator animator;

    public float speed = 10f;


    void Update()
    {
        // Mover el proyectil hacia adelante a una velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (!other.gameObject.CompareTag("Enemy"))
        //{
        //    Debug.Log("Colision con player");
        //    //animator.SetTrigger("Hit");
        //    Destroy(gameObject);
        //}
        //if (other.gameObject.TryGetComponent(out LifePlayer player))
        //{
        //    player.TakeDamage(1);
        //    animator.SetTrigger("Hit");
        //    Debug.Log("vida restada");
        //}
    }
}
