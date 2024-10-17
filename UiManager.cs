using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class UiManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    private void OnEnable()
    {
       Health_Bar2.OnPlayerDeath += EnableGameOverMenu;
    }

    private void OnDisable()

    {
        Health_Bar2.OnPlayerDeath-= EnableGameOverMenu;


    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }


    
}
