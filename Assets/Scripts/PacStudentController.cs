using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PacStudentController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 direction = Vector3.right;
    int[,] levelMap =
         {
         {1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2},
         {2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2},
         {2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2},
         {2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2},
         {2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2},
         {1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1},
         {0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0},
         {0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0},
         {0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0},
         {2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2},
         {0,0,0,0,0,0,5,0,0,0,4,0,0,0,0,0,0,4,0,0,0,5,0,0,0,0,0,0},

         {2,2,2,2,2,1,5,3,3,0,4,0,0,0,0,0,0,4,0,3,3,5,1,2,2,2,2,2},
         {0,0,0,0,0,2,5,4,4,0,3,4,4,0,0,4,4,3,0,4,4,5,2,0,0,0,0,0},
         {0,0,0,0,0,2,5,4,4,0,0,0,0,0,0,0,0,0,0,4,4,5,2,0,0,0,0,0},
         {0,0,0,0,0,2,5,4,3,4,4,3,0,3,3,0,3,4,4,3,4,5,2,0,0,0,0,0},
         {1,2,2,2,2,1,5,4,3,4,4,3,0,4,4,0,3,4,4,3,4,5,1,2,2,2,2,1},
         {2,5,5,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,4,4,5,5,5,5,5,5,2},
         {2,5,3,4,4,3,5,4,4,5,3,4,4,3,3,4,4,3,5,4,4,5,3,4,4,3,5,2},
         {2,5,3,4,4,3,5,3,3,5,3,4,4,4,4,4,4,3,5,3,3,5,3,4,4,3,5,2},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,2},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,3,3,5,3,4,4,4,3,5,3,4,4,3,5,2},
         {2,6,4,0,0,4,5,4,0,0,0,4,5,4,4,5,4,0,0,0,4,5,4,0,0,4,6,2},
         {2,5,3,4,4,3,5,3,4,4,4,3,5,4,4,5,3,4,4,4,3,5,3,4,4,3,5,2},
         {2,5,5,5,5,5,5,5,5,5,5,5,5,4,4,5,5,5,5,5,5,5,5,5,5,5,5,2},
         {1,2,2,2,2,2,2,2,2,2,2,2,2,7,7,2,2,2,2,2,2,2,2,2,2,2,2,1},
         };
    Vector3 target;
    Vector3 current;
    float moveTime = 0.2f;
    float t = 0;
    bool startedMove = false;
    private KeyCode lastInput;
    bool moved;
    int[] currentSpot = new int[2] { 1, 1 };
    int nextTile = 5;
    bool check;


    void Start()
    {
        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(nextTile);
        //Debug.Log(currentSpot[0]);
        //Debug.Log(currentSpot[1]);

        if (Input.GetKeyDown(KeyCode.A))
        {
            //direction = Vector3.left;
               
            lastInput = KeyCode.A;
            check = false;
            //nextTile = levelMap[currentSpot[0], currentSpot[1] - 1];

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //direction = Vector3.down; 
            lastInput = KeyCode.S;
            check = false;
            //nextTile = levelMap[currentSpot[0] + 1, currentSpot[1]];

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           // direction = Vector3.right;
                
            lastInput = KeyCode.D;
            check = false;
            //nextTile = levelMap[currentSpot[0] , currentSpot[1] + 1];
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            check = false;
            lastInput = KeyCode.W;
            
            //
        }
       
    }

    public IEnumerator move()
    {
        while (true){
            t = 0;
            currentSpot[1] = (int)(transform.position.x + 8.5f);
            currentSpot[0] = Math.Abs((int)(transform.position.y - 4.5f));
            Debug.Log(currentSpot[0]);
            /*if (currentSpot[0] >= 13)
            {
                currentSpot[0] = 0;
            }

            else if (currentSpot[1] >= 13)
            {

                currentSpot[1] = 0;
            }
            */
            int tempTile = nextTile;
            if (!check)
            {
                if (lastInput == KeyCode.W)
                {
                    nextTile = levelMap[currentSpot[0] - 1, currentSpot[1]];
                    if (nextTile == 5 || nextTile == 6 || nextTile == 0)
                    {
                        direction = Vector3.up;
                        check = true;
                    }
                    else
                    {
                        nextTile = tempTile;
                    }
                }
                if (lastInput == KeyCode.D)
                {
                    nextTile = levelMap[currentSpot[0], currentSpot[1] + 1];
                    if (nextTile == 5 || nextTile == 6 || nextTile == 0)
                    {
                        direction = Vector3.right;
                        check = true;
                    }
                    else
                    {
                        nextTile = tempTile;
                    }
                }
                if (lastInput == KeyCode.S)
                {
                    nextTile = levelMap[currentSpot[0] + 1, currentSpot[1]];
                    if (nextTile == 5 || nextTile == 6 || nextTile == 0)
                    {
                        direction = Vector3.down;
                        check = true;
                    }
                    else
                    {
                        nextTile = tempTile;
                    }
                }
                if (lastInput == KeyCode.A)
                {
                    nextTile = levelMap[currentSpot[0], currentSpot[1] - 1];
                    if (nextTile == 5 || nextTile == 6 || nextTile == 0)
                    {
                        direction = Vector3.left;
                        check = true;
                    }
                    else
                    {
                        nextTile = tempTile;
                    }
                }
            }



            if (direction == Vector3.right)
            {
                nextTile = levelMap[currentSpot[0], currentSpot[1] + 1];

            }
            if (direction == Vector3.left)
            {
                nextTile = levelMap[currentSpot[0], currentSpot[1] - 1];
            }
            if (direction == Vector3.up)
            {
                nextTile = levelMap[currentSpot[0] - 1, currentSpot[1]];
            }
            if (direction == Vector3.down)
            {
                nextTile = levelMap[currentSpot[0] + 1, currentSpot[1]];
            }

            current = transform.position;
            target = transform.position + direction;
            if (nextTile == 5 || nextTile == 6 || nextTile == 0)
            {
                while (t < moveTime)
                {
                    transform.position = Vector3.Lerp(current, target, (t / moveTime));
                    t += Time.deltaTime;
                    
                    yield return null;
                }
                moved = true;
                
            }
            else
            {
                moved = false;
                yield return null;
            }

            

            if (moved)
            {
                
                transform.position = target;
                

                
               
            }
            

        }
    }
}
