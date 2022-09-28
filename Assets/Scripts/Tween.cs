using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }


    public Tween(Transform t, Vector3 s, Vector3 e, float st, float d)
    {
        this.Target = t;
        this.StartPos = s;
        this.EndPos = e;
        this.StartTime = st;
        this.Duration = d;
    }



}
