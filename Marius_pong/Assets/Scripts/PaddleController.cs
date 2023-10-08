using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    public KeyCode upKey;
    public KeyCode downKey;

    public GameObject paddle;

    private Rigidbody2D rig;

    private int triggerCour;

    private Vector3 originalScale;

    private float originalspeed;

    public bool rightPaddle;

    public Collider2D ball;


    void Start()
    {
        rig=GetComponent<Rigidbody2D>();
         triggerCour=0;
         rightPaddle=true;
         originalScale=transform.localScale;
         originalspeed=speed;
         StartCoroutine(Wait5Second());
     
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 movement= GetInput();

      MoveObject(movement);
      
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up*speed;
        }
        else if (Input.GetKey(downKey))
        {
             return Vector2.down*speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
          //transform.Translate(movement*Time.deltaTime);
          Debug.Log("TEST Kecepatan Paddle : "+movement);
          rig.velocity=movement;
    }

    public void activatePULongPaddle(float longsize)
    {
        paddle.transform.localScale += new Vector3(0.0f,longsize,0.0f);
        triggerCour=1;

    }

    public void deactivatePULongPaddle()
    {
        Debug.Log("Return paddle to normal");
       paddle.transform.localScale=originalScale;
    }

    public void activatePUSpeedPaddle(float addSpeed)
    {
       speed*=addSpeed;
       Debug.Log("check paddle speedup");
       triggerCour=2;

    }

    public void deactivatePUSpeedPaddle()
    {
        Debug.Log("Return paddle Speed to normal");
        speed=originalspeed;
    }

    private IEnumerator Wait5Second()
    {

    while (true)
        {
        if (triggerCour==1)
            {
            yield return new WaitForSeconds(5f);
            deactivatePULongPaddle();
            triggerCour=0;
            }
        if (triggerCour==2)
            {
             yield return new WaitForSeconds(5f);
            deactivatePUSpeedPaddle();
            triggerCour=0;
            }
        yield return null;
        }
    }

//    void OnCollisionEnter2D(Collision2D col)
//     {
//         if ( col.gameObject.CompareTag("PaddleKanan"))
//         {
//             Debug.Log("Kena Paddle Kanan");
//             rightPaddle = true;
//         }
//         else if (col.gameObject.CompareTag("PaddleKiri"))
//         {
//             Debug.Log("Kena Paddle Kiri");
//             rightPaddle=false;
//         }
//         }



}
