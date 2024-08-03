using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePlayer : MonoBehaviour
{

    [SerializeField] RawImage[] hearts;

    private int maxHealth = 4;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TakeDamage(int daño)
    {
        //logica de daño del player
    }

    private void UpdateLife(int hp)
    {
        //logica para actualizar UI;
    }
}
