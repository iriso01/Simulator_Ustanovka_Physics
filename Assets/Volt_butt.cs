using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volt_butt : MonoBehaviour
{
    public Animator door;
    private bool isAnimationPlaying = true;

    void Start()
    {
        door = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (isAnimationPlaying)
        { 
            isAnimationPlaying = false;
            door.SetBool("run", false);  
        }
       else  
        {
            isAnimationPlaying = true;
            door.SetBool("run", true);  
        }
    }
}
