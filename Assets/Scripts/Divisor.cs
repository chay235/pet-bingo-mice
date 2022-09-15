using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Divisor : MonoBehaviour
{
    public int divisor;

    void OnEnable()
    {

        divisor = Random.Range(1, 2);
        GetComponent<TMP_Text>().text = divisor.ToString();
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
