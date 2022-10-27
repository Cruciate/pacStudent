using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    // private Vector3 oldpos;

    [SerializeField] private GameObject pacStudent;
    private Animator anim;
    private Tweener tweener;
    private AudioSource audio;
    [SerializeField] private AudioClip movementSound;


    private Vector3[] positionArray =
    {
        new Vector3(-2.5f,3.5f,0),
        new Vector3(3.5f,3.5f,0),
        new Vector3(3.5f,-0.5f,0),
        new Vector3(-2.5f,-0.5f,0)

    };


    private string[] animArray =
    {
        "walkUp",
        "walkRight",
        "walkDown",
        "walkLeft"
    };

    private float[] durationArray = { 1.5f, 2f, 1.5f, 2f };
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        anim = GetComponent<Animator>();
        //StartCoroutine(move());
        audio = GetComponent<AudioSource>();
        audio.clip = movementSound;
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(audio);

        
        
    }


    /*IEnumerator move()
    {
        while (true)
        {
            for (int i = 0; i < 4; i++)
            {
                tweener.AddTween(pacStudent.transform, pacStudent.transform.position, positionArray[i], durationArray[i]);
                anim.Play(animArray[i]);
                if (!GetComponent<AudioSource>().isPlaying)
                {
                    GetComponent<AudioSource>().Play();
                }
                yield return new WaitForSeconds(durationArray[i]);
            }
        }
    }
    */

}
    

    
