using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class ClickBut : MonoBehaviour, IPointerClickHandler
{
    float Val1 = 0f;
    float Val2 = 0f;
    public GameObject Text1;
    public GameObject Text2;
    int count = 1;

    void Start()
    {
       
    }

    public void OnPointerClick(PointerEventData eventData)
    {
         StartCoroutine(UpdateValuesCoroutine());
    }

    IEnumerator UpdateValuesCoroutine()
    {
        while (count<=3)
        {
            yield return new WaitForSeconds(5f); // Ждем 5 секунд

            Val1 += 10f;
            Text1.GetComponent<TextMesh>().text = Val1.ToString() + " °C"; // Округляем до двух знаков после запятой
           

            Val2 += Val1 /2.1f;
            Text2.GetComponent<TextMesh>().text = Val2.ToString() + " Ом"; // Округляем до двух знаков после запятой

            count++;
        }
    }
}
