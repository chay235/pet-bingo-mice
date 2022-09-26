using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bingo_Movement : MonoBehaviour
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

        transform.DOLocalMoveX(-192f, 2f);
        yield return new WaitForSeconds(2f);

        transform.DOLocalMoveX(323f, 2f);
        yield return new WaitForSeconds(2f);


        scale = Vector3.one;
        scale.x = 1;
        transform.localScale = scale;

        transform.DOLocalMoveX(currentPos, 2f);
        yield return new WaitForSeconds(2f);
        StartCoroutine(Move());
    }
}
