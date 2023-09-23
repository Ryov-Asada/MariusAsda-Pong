using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreController : MonoBehaviour
{
   public TMP_Text skorKiri;
   public TMP_Text skorKanan;

   public ScoreManager manager;

//  void Start()
//  {
//     skorKiri=GetComponent<TMP_Text>();
//     skorKanan=GetComponent<TMP_Text>();
//  }
void Update()
    {
        skorKiri.text=manager.leftScore.ToString();
        skorKanan.text=manager.rightScore.ToString();
    }
}
