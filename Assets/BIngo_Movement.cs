using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BIngo_Movement : MonoBehaviour
{
    float currentPos = 0f;

    void Start()
    {
        currentPos = transform.localPosition.x;
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        Vector3 scale = Vector3.one;
        transform.localScale = scale;

        transform.DOLocalMoveX(-192f, 12f);
        yield return new WaitForSeconds(12f);

        scale = Vector3.one;
        scale.x = 1;
        transform.localScale = scale;

        transform.DOLocalMoveX(currentPos, 8f);
        yield return new WaitForSeconds(8f);
        StartCoroutine(Move());
    }
}
