using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    //private Tween activeTween;

    private List<Tween> activeTweens = new List<Tween>();

    private float td;
    private float tl;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = activeTweens.Count - 1; i >= 0; i--)
        {
            Tween activeTween = activeTweens[i];
            if (activeTween != null)
            {
                tl = (Time.time - activeTween.StartTime) / activeTween.Duration;
                
                if (Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
                {
                    activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, tl);
                }

                else
                {
                    activeTween.Target.position = activeTween.EndPos;
                    activeTweens.RemoveAt(i);// = null;
                }
            }
        }
    }


    public bool AddTween(Transform targetObject, Vector3 StartPos, Vector3 EndPos, float duration)
    {
        if (TweenExists(targetObject))
        {
            return false;
        }
        else
        {
            //if (activeTween == null)
            //{
            //Tween activeTween = new Tween(targetObject, StartPos, EndPos, Time.time, duration);
            activeTweens.Add(new Tween(targetObject, StartPos, EndPos, Time.time, duration));
            return true;
            //}
        }



    }


    public bool TweenExists(Transform target)
    {
        bool flag = false;

        for (int i = 0; i < activeTweens.Count; i++)
        {
            if (activeTweens[i].Target == target)
            {
                flag = true;
            }
        }
        return flag;

    }
}

