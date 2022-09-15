using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DivisorDividend : MonoBehaviour
{

 
    int dividend;
    int divisor;
    public int answer;

    private void OnEnable()
    {
  
        dividend = Random.Range(0, 10);
        GetComponent<TMP_Text>().text = dividend.ToString();
        

       // divisor = Random.Range(0, 10);
       // GetComponent<TMP_Text>().text = divisor.ToString();

       // answer = dividend / divisor;
       // GetComponent<TMP_Text>().text = answer.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}