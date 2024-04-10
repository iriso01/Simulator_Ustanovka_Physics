using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Run : MonoBehaviour, IPointerClickHandler
{
    private Animator anim;
    private bool isButtonClicked = false;
    private bool isTKeyPressed = false; // Флаг, отслеживающий нажатие клавиши "T"

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isTKeyPressed && Input.GetKeyDown(KeyCode.F))
        {
            isTKeyPressed = true;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isTKeyPressed)
        {
            if (!isButtonClicked)
            {
                anim.SetInteger("Stage", 1);
                isButtonClicked = true;

            }
            else
            {
                anim.SetInteger("Stage", 0);
                isButtonClicked = false;

            
            }
        }
        else
        {
           
            Debug.Log("Нажмите клавишу 'F', чтобы разрешить выполнение действия кнопки.");
        }
    }
}
