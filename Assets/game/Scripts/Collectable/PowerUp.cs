using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Collectable;

public abstract class PowerUp : MonoBehaviour, ICollectItem
{

    public delegate void PowerUpEvent();
    public static PowerUpEvent powerUpEvent;

    protected float duration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected abstract void OnPowerUp();

    public void CollectItem()
    {
        powerUpEvent?.Invoke();
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            CollectItem();
        }
    }
}
