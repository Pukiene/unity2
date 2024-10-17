using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public GameObject player2;

    private Vector3 homePosition;


    // Start is called before the first frame update
    void Start()
    {
        homePosition = player.transform.position;
        Debug.Log(homePosition);
    }

    // Update is called once per frame
    void Update()
    {
        //SceneManager.LoadScene("Scene");
//player.transform.position = homePosition;

       /* if(player.transform.position.y < -10)
        {
            Debug.Log("You Died!!");
            player.transform.position = homePosition;
        }*/
        
    }

    void LateUpdate()
    {
        //player.transform.position = homePosition;
        if(player.transform.position.y < -10)
        {
            Debug.Log("You Died!!");
            player.transform.position = homePosition;
        }
    }

}
