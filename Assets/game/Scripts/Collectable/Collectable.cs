using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour, ICollectItem
{

    public delegate void CollectibleEvent();
    public static CollectibleEvent colllectibleEvent;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectItem()
    {
        colllectibleEvent?.Invoke();
        animator.SetTrigger("Collected");
        Destroy(gameObject, 0.5f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CollectItem();

        }
    }


}
