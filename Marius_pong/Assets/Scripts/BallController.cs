using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public bool rightPaddle;

    void Start()
    {
        rig= GetComponent<Rigidbody2D>();
        rig.velocity=speed;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position= transform.position + (new Vector3(1f,1f,0)*Time.deltaTime);
        //transform.Translate(new Vector3(1f,1f,0)*Time.deltaTime);
        //transform.Translate(speed*Time.deltaTime);
    }

    public void ResetBall()
    {
        transform.position= new Vector3(resetPosition.x,resetPosition.y,1);
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity*=magnitude;
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if ( col.gameObject.tag=="PaddleKanan")
        {
            Debug.Log("Kena Paddle Kanan");
            rightPaddle = true;
        }
        else if (col.gameObject.tag=="PaddleKiri")
        {
            Debug.Log("Kena Paddle Kiri");
            rightPaddle=false;
        }
     }
}
