using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongPaddle : MonoBehaviour
{
    // Start is called before the first frame update
  

   public Collider2D ball;
   public BoxCollider2D paddleKiri,paddleKanan;
    public float sizeLong;

    public int removeInterval;

     private float removetimer;

    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision==ball)
        {

            Debug.Log("collision check Long");
           paddleKiri.GetComponent<PaddleController>().activatePULongPaddle(sizeLong);
           paddleKanan.GetComponent<PaddleController>().activatePULongPaddle(sizeLong);
           // ball.GetComponent<PaddleController>().activatePULongPaddle(sizeLong);
            manager.RemovePowerUp(gameObject);
        }
    }

    private void Start()
    {
        removetimer=0;
        //paddleKiri=GetComponent<GameObject>();
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
