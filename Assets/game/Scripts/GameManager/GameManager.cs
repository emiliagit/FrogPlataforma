using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI recolectablesText;

    private int contador;

    private void Start()
    {
        
    }
    void Inventory()
    {
        contador++;
        recolectablesText.text = "Obects collected: " + contador;

        if (contador == 11)
        {
            SceneManager.LoadScene("Level1");
        }
    }

   

    private void OnEnable()
    {
        Collectable.colllectibleEvent += Inventory;
    }

    private void OnDisable()
    {
        Collectable.colllectibleEvent -= Inventory;
    }

   
}
