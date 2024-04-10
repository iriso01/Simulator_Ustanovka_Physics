using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformText : MonoBehaviour
{
   
    private void Start()
    {
      
        Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    
    public void HideObjectExternally()
    {
        Hide();
    }
    public void ShowObject()
{
    
    gameObject.SetActive(true);
}
public void Open()
    {
       ShowObject();
    }


}
