using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public TextMeshProUGUI recolectablesText;

    private int contador;

    private void Start()
    {
        
    }
    void Inventory()
    {
        contador++;
        recolectablesText.text = "Food collected: " + contador;

        if (contador == 10)
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
