using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class EnemyPadre : MonoBehaviour
{

    protected float hp;

    //public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0) 
        {
            Destroy(gameObject); 
        }
    }

   public void TakeDamage(float dmg)
    {
        hp -=dmg;
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out LifePlayer player))
        {
            player.GetComponent<ITakeDamage>().TakeDamage(2);
           
        }
    }

    protected abstract void Attack();



}
