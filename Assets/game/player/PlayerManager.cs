using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed;

    private bool grounded;
    public float fuerzaSalto;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Movimiento()
    {
        //control de desplazamiento, salto y animaciones del player
    }

    private void OnCollisionEnter(Collision collision)
    {
        //logica de colisiones con objetos de la escena
    }
}
