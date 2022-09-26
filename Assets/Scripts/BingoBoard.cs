using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class BingoBoard : MonoBehaviour, IPointerClickHandler
{

    Quotient quotient;

    int _bingNum;

    public void Awake()
    {
        quotient = GameObject.Find("quotient").GetComponent<Quotient>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (this._bingNum == quotient.quotient)
        {
            Debug.Log(true);
            GetComponent<TMP_Text>().color = Color.green;
        }
        else
        {
            Debug.Log(false);
            GetComponent<TMP_Text>().color = Color.red;
        }
    }

    private void OnEnable()
    {
        _bingNum = UnityEngine.Random.Range(1, 10);
        GetComponent<TMP_Text>().text = _bingNum.ToString();  
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
