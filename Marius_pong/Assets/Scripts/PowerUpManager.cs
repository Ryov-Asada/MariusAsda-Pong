using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxPowerUpAmount;
    public List<GameObject> powerUpTemplateList;

    private List<GameObject> powerUpList;

    public Transform spawnArea;
    public Vector2 powerUpAreaMin;
    public Vector2 powerUpAreaMax;

    public int spawnInterval;
    
    private float timer;
    



    void Start()
    {
       powerUpList= new List<GameObject>(); 
       timer=0;
       
    }

    

    private void Update()
    {
        timer+=Time.deltaTime;
        

        if (timer>spawnInterval)
        {
            GenerateRandomPowerup();
            timer-=spawnInterval;
        }
        
        
    }
    
    public void GenerateRandomPowerup()
    {
        GenerateRandomPowerup(new Vector2(Random.Range(powerUpAreaMin.x,powerUpAreaMax.x),Random.Range(powerUpAreaMin.y,powerUpAreaMax.y)));
    }

    public void GenerateRandomPowerup(Vector2 position)
    {
        if (powerUpList.Count>=maxPowerUpAmount)
        {
            return;
        }

        if (position.x<powerUpAreaMin.x || position.x>powerUpAreaMax.x || position.y<powerUpAreaMin.y || position.y>powerUpAreaMax.y)
        {
            return;
        }
        int RandomIndex= Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp= Instantiate(powerUpTemplateList[RandomIndex], new Vector3(position.x, position.y, powerUpTemplateList[RandomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);
        powerUpList.Add(powerUp);
    }

    public void RemovePowerUp(GameObject powerUp)
        {
            powerUpList.Remove(powerUp);
            Destroy(powerUp);

        }

    public void RemoveAllPowerUp()
    {
        while (powerUpList.Count>0)
        {
            RemovePowerUp(powerUpList[0]);
        }
    }

   
}
