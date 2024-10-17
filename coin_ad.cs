
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsCollector : MonoBehaviour
{
    private int consCount = 0;
    private string strConsCount;

    void Start()
    {
        strConsCount = "Cons Collected: " + consCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("1");
        if(collision.gameObject.tag.Equals("Crate"))
        {
            consCount++;
        }
        strConsCount = "Cons Collected: " + consCount;
         Debug.Log("2");
    }

   // private void OnGUI()
  //  {
  //      GUI.color = Color.white;
  //      GUI.Label(new Rect(10, 10, Screen.width, Screen.height), strConsCount);
  //  }
}