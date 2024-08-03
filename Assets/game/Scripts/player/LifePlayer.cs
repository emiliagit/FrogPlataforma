using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour, ITakeDamage
{
    public Slider slider;

    public float hp;

    public float Hp { get => hp; set => hp = value; }

    // Start is called before the first frame update
    void Start()
    {
        hp = 6;
        
        UpdateHealthUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        UpdateHealthUI();
    }

    public void TakeDamage(float damageToTake)
    {
        hp -= damageToTake;
        UpdateHealthUI();
    }



    void UpdateHealthUI()
    {
        hp = Mathf.Clamp(hp, 0, 100);
        slider.value = hp;
    }
}
