using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{


    float t;
    float startx;
    float starty;
    float moveTime = 6.0f;
    private Vector3 target, current;
    bool spawned;
    float targetx;
    float targety;
    bool moving;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ok");
        spawnCherry();
        spawned = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void spawnCherry()
    {
        StopCoroutine(moveCherry());
        if (Random.Range(0, 2) == 0)
        {
            startx = -26;
            targetx = 36;
        }
        else
        {
            startx = 36;
            targetx = -26;
        }
        starty = Random.Range(-23, 4);
        transform.position = new Vector3(startx, starty, 0);
        
        StartCoroutine(moveCherry());
    }


    private IEnumerator moveCherry()
    {
        

        current = transform.position;
        //float diff = 9.5 - starty;
        targety = -(starty + 9.5f * 2);
        target = new Vector3(targetx, targety, 0);
        Debug.Log(current.x);
        Debug.Log(target.x);

        while (t < moveTime)
        {
            transform.position = Vector3.Lerp(current, target, (t / moveTime));
            t += Time.deltaTime;
            yield return null;
            moving = true;

        }
        transform.position = target;
            
        moving = false;
        spawned = false;
        if(transform.position == target)
        {
            Debug.Log("destroying");
            Destroy(gameObject);
        }
        
        
        
    }
}
