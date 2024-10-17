using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;




public class YouWin : MonoBehaviour
{
  public GameObject YouWin1;
  public int coin;
  private bool FirstRun = true;


void Update()
{
  
    LoadFromJson();
  
  
  if(coin >= 49)
  {
    //Debug.Log("naujas failas1 " + coin);

    EnableYouWin();
    SaveToJson();
  }
}

  public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerStatuses.json");
        PlayerStats data = JsonUtility.FromJson<PlayerStats>(json);
        coin = data.coin;
        //Debug.Log("naujas failas2 " + coin);
    }
  void SaveToJson()
    {    
        PlayerStats data = new PlayerStats();
        data.ID = 1;
        data.coin = 0;
         string Json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/PlayerStatuses.json", Json);
        // Debug.Log(Application.dataPath + "/PlayerStatuses.json");
    } 
     public void EnableYouWin()
    {
        YouWin1.SetActive(true);
    }

    

}
