using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // g�rselde bo�luk olu�mamas� i�in yar�s� kaybolunca yenisi tekrar eder
    }


    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        { transform.position = startPos; }
    }
}
