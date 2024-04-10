
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using static System.Math;
public class outputinf : MonoBehaviour
{
  

    
    [SerializeField]
    InputField textInput;
    [SerializeField]
    Text u1;
    [SerializeField]
    Text i1;
    [SerializeField]
    Text u2;
    [SerializeField]
    Text i2;
    [SerializeField]
    Text u3;
    [SerializeField]
    Text i3;
    [SerializeField]
    Text u7;
    [SerializeField]
    Text u8;
    [SerializeField]
    Text u9;
    [SerializeField]
    Text u10;
    [SerializeField]
    Text u11;
    [SerializeField]
    Text u12;
    
    double sigma = 1.0;
    double Ea = 1.1; 
    double k = 8.617333262145 * Math.Pow(10, -5); 
 

   public void OnButtonClicked()
{
    
    if (u1.text == "_")
    {
        if (float.TryParse(textInput.text, out float inputValue))
        {
            u1.text = (inputValue + 273f).ToString();
            u7.text = (1/float.Parse(u1.text)).ToString(); 
            u10.text = ( sigma * Math.Exp(-Ea / (2 * k *(float.Parse(u1.text))))).ToString();          
             

        }
    }
    else if (i1.text == "_")
    {
        i1.text = textInput.text;
    }
    else if (u2.text == "_")
    {
        if (float.TryParse(textInput.text, out float inputValue))
        {
            u2.text = (inputValue + 273f).ToString();
            u8.text = (1/float.Parse(u2.text)).ToString(); 
            u11.text = ( sigma * Math.Exp(-Ea / (2 * k *(float.Parse(u2.text))))).ToString();       
        }
    }
    else if (i2.text == "_")
    {
        i2.text = textInput.text;
    }
    else if (u3.text == "_")
    {
        if (float.TryParse(textInput.text, out float inputValue))
        {
            u3.text = (inputValue + 273f).ToString();
            u9.text = (1/float.Parse(u3.text)).ToString();
            u12.text = ( sigma * Math.Exp(-Ea / (2 * k *(float.Parse(u3.text))))).ToString();     
        }
    }
    else if (i3.text == "_")
    {
        i3.text = textInput.text;
    }     

               
    textInput.text = "";
}
    
    public void Clean()
    {
        u1.text = "_";
        u2.text = "_";
        u3.text = "_";
        i1.text = "_";
        i2.text = "_";
        i3.text = "_";
        u7.text = "_";
        u8.text = "_";
        u9.text = "_";
        u10.text = "_";
        u11.text = "_";
        u12.text = "_";
               
               
    }

}



