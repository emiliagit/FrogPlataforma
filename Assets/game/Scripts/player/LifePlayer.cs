using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifePlayer : MonoBehaviour
{
    public Slider slider;

    public float hp;
  

    // Start is called before the first frame update
    void Start()
    {
        hp = 1;
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
