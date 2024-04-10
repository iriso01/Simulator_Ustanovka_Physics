using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{

    bool move = false;
    float speed = 0.01f;
    float offset = 0;
    Vector3 startPosition;
    Vector3 needPosition;
    Quaternion startRotation;
	Quaternion needRotaton;
	public void Move0()    
    {
		move = true;
		startPosition = transform.position;
		startRotation = transform.rotation;

		
		needPosition = new Vector3(0f, 883f, 451f);
		needRotaton = Quaternion.Euler(15.857f, 0f, 0f);

		
	}
    public void Move1()         
    {
		move = true;
		startPosition = transform.position;
		startRotation = transform.rotation;

		
		needPosition = new Vector3(104f, 815.7f, 586.5f);
		needRotaton = Quaternion.Euler(11.167f, 0f, 0f);

		
	}
    public void Move2()     
    {
        move = true;
        startPosition = transform.position;
        startRotation = transform.rotation;
        needPosition = new Vector3(-128.3f, 768.4f, 661.4f);
		needRotaton = Quaternion.Euler(11.167f, 0f, 0f);
	}
  
    void Update()
    {
        if (move)
        {
            offset += speed;
            transform.position = Vector3.Lerp(startPosition, needPosition, offset);
			transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);
			if (offset >= 1)
            {
                move = false;
                offset = 0;
            }
        }
    }

}
