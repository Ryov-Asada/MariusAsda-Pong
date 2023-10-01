using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D ball;
    public float magnitude;

    public int removeInterval;

     private float removetimer;

    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision==ball)
        {
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }

    private void Start()
    {
        removetimer=0;
    }
    private void Update()
    {
        removetimer+=Time.deltaTime;
        if (removetimer>removeInterval)
        {
            manager.RemovePowerUp(gameObject);
            removetimer-=removeInterval;
        }

    }
    
}
