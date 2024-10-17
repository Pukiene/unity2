using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class coin_colect : MonoBehaviour
{
  private int Coin = 0;
  private bool FirstRun = true;
 // private bool coinCollected = false;
  public TextMeshProUGUI coinText;

private int getCoin()
{
  return(Coin);
}
  private void OnTriggerEnter(Collider other)
  {  
    if(other.transform.tag == "Coin")
    {
        Coin++;
        //coinText.text = "Coin: " + Coin.ToString();
        Debug.Log("Coins collected: " + Coin);
        Destroy(other.gameObject);
        SaveToJson();
        //coinCollected = true;
        //from 
    }
  } 
     // Debug.Log("Coins collected 1 : " + Coin);
        //if (coinCollected)
        //{
          
          //Debug.Log("Coins collected 2 : " + Coin);
          
           // coinCollected = false; // Reset the flag
       // }

       public void OnGUI()
       {
        GUI.color = Color.white;
        GUI.Label(new Rect(10, 10, Screen.width, Screen.height), "Coins Collected: " + Coin.ToString());
       }
    void SaveToJson()
    {
   
    
        PlayerStats data = new PlayerStats();
        data.ID = 1;
        data.coin = Coin;
         string Json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/PlayerStatuses.json", Json);
        // Debug.Log(Application.dataPath + "/PlayerStatuses.json");
    }
    
}


    
