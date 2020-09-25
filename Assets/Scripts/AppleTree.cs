using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
  
    public float SecondsBetweenAppleDrops = 1f;
    void Start()
    {
        //drop apple
        InvokeRepeating("DropApple", 2f, SecondsBetweenAppleDrops);
    }
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        //movement, change direction
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }else if (pos.x > leftAndRightEdge)
        {
            speed = -Math.Abs(speed);
        }
    }

    void FixedUpdate()
    {

    }
}
