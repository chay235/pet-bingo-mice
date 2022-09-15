using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quotient : MonoBehaviour
{
    Dividend dividend;
    Divisor divisor;

    public int quotient;

    private void Awake()
    {
        dividend = GameObject.Find("dividend").GetComponent<Dividend>();
        divisor = GameObject.Find("divisor").GetComponent<Divisor>();
    }

    void OnEnable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        quotient = dividend.dividend / divisor.divisor;
        GetComponent<TMP_Text>().text = quotient.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
