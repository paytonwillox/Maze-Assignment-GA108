using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour

{
    // position that triggers a win
    public Transform winPoint;
    //renaming

    public Vector3 apple = new Vector3(27, 1, 15);
    
   
    // player position
    public Transform player;
    void Update()
    {
        float distToWin = Vector3.Distance(player.position, apple);
        if (distToWin <= 1.5f)
        {
            Debug.Log("You Win!");
        }
    }
}