using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip clip1;
    public AudioClip clip2;
    void Start()
    {
        GetComponent<AudioSource>().clip = clip1;
        GetComponent<AudioSource>().Play();
        StartCoroutine(playSound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator playSound()
    {
        //GetComponent<AudioSource>().clip = clip1;
        yield return new WaitForSeconds(1);
        GetComponent<AudioSource>().clip = clip2;
        GetComponent<AudioSource>().Play();
    }
}
