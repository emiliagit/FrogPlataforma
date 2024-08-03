using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPW : PowerUp
{
    [SerializeField, Range(1.1f, 1.5f)] private float speedMultiplier;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void OnPowerUp()
    {
        StartCoroutine(SpeedBuff());
    }



    private IEnumerator SpeedBuff()
    {
        PlayerManager player = FindObjectOfType<PlayerManager>();

        player.moveSpeed *= speedMultiplier;

        yield return new WaitForSeconds(duration);

        player.moveSpeed /= speedMultiplier;
    }
}
