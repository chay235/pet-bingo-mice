using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Dividend : MonoBehaviour
{
    public int dividend;

    void OnEnable()
    {

        dividend = Random.Range(2, 10);
        GetComponent<TMP_Text>().text = dividend.ToString();
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
