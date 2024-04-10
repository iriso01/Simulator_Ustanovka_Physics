using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_door : MonoBehaviour
{
   public Animator door;

    void Start()
    {
        door = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        { 
            door.SetBool("run", true);  
        }
        if (Input.GetKeyDown(KeyCode.F))   
        {
            door.SetBool("run", false);  
        }
    }

}
