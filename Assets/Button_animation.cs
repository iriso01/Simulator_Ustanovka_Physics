using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_animation : MonoBehaviour
{
  
    public Animator door;
    private bool isAnimationPlaying = false;

    void Start()
    {
        door = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (isAnimationPlaying)
        { 
            isAnimationPlaying = false;
            door.SetBool("run", true);  
        }
       else  
        {
            isAnimationPlaying = true;
            door.SetBool("run", false);  
        }
    }

}

