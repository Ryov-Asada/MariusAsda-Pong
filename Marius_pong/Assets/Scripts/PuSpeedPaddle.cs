using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuSpeedPaddle : MonoBehaviour
{
     public Collider2D ball;
   public BoxCollider2D paddleKiri,paddleKanan;
    public float addSpeed;

    public int removeInterval;

     private float removetimer;

    public PowerUpManager manager;
    //public PaddleController paddleNaming;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision==ball)
        {
               Debug.Log("collision check speed kanan");
           paddleKiri.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
           paddleKanan.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
            manager.RemovePowerUp(gameObject);
        //     if (paddleNaming.rightPaddle==true)
        //     {
        //          Debug.Log("collision check speed kanan");
        //    //paddleKiri.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
        //    paddleKanan.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
        //     manager.RemovePowerUp(gameObject);
        //     }
        //     else if  (paddleNaming.rightPaddle==false)
        //     {
        //     Debug.Log("collision check speed kiri");
        //    paddleKiri.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
        //    //paddleKanan.GetComponent<PaddleController>().activatePUSpeedPaddle(addSpeed);
        //     manager.RemovePowerUp(gameObject);
        //     }
           
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
