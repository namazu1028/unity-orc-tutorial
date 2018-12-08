using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Vector3 startPosition; //開始座標
    private void Update()
    {
        transform.position = startPosition + new Vector3(0, 0, Mathf.Sin(Time.time));
    }
    private void Start()
    {
        startPosition = GetComponent<Transform>().position;
    }
}