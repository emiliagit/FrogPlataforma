using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyPadre : MonoBehaviour
{

    public Slider healthSlider;

    protected float hp;

    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Movement()
    {
        //rango de movimiento de los enemigos que puede ser modificado o no en las clases hijas
    }

    protected virtual void RecibirDaño()
    {
        //daño del enemigo 
    }

    protected void UpdateHealthUI()
    {
        //actualizacion de interfaz
    }

    private void OnCollisionEnter(Collision collision)
    {
        //colision de enemgios con player y generar daño
    }

    protected abstract void Attack();



}
