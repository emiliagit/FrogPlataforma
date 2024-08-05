using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI recolectablesText;

    public string nextLevelScene;

    private int contador;

    private void Start()
    {
        
    }
    void Inventory()
    {
        contador++;
        recolectablesText.text = "Obects collected: " + contador;

        if (contador == 10)
        {
            NextLevel2(nextLevelScene);
        }
    }

    private void NextLevel2(string level)
    {
        SceneManager.LoadScene(level);
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
