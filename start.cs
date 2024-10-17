
using UnityEngine;

public class start : MonoBehaviour

{
    public Vector3 startPosition; 

    void Start()
    {
        transform.position = startPosition;
    }
}