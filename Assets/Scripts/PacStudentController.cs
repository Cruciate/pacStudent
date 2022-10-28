using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 direction = Vector3.up;

    Vector3 target;
    Vector3 current;
    float moveTime = 0.2f;
    float t = 0;
    bool startedMove = false;
    private KeyCode lastInput; 

    void Start()
    {
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
               
            lastInput = KeyCode.A;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down;
            lastInput = KeyCode.S;
                
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
                
            lastInput = KeyCode.D;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.up;
            lastInput = KeyCode.W;
        }
       
    }

    public IEnumerator move()
    {
        while (true){
            t = 0;

            current = transform.position;

            target = transform.position + direction;
            
            while (t < moveTime)
            {
                transform.position = Vector3.Lerp(current, target, (t / moveTime));
                t += Time.deltaTime;
                yield return null;
            }

            transform.position = target;
            
        }
    }
}
