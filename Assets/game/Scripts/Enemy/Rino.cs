using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rino : EnemyPadre
{

    public float moveDistance ;  // Distancia de movimiento en el eje X
    public float moveSpeed = 2f;     // Velocidad de movimiento

    private Vector3 startPosition;
    private bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        transform.localScale = new(-3f, 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    protected override void Attack()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false;
                transform.localScale = new(3f, 3f, 3f);

            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true;
                transform.localScale = new(-3f, 3f, 3f);


            }
        }
    }

   
}
