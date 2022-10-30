using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateCherry : MonoBehaviour
{

    public GameObject cherryPrefab;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cherrySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnCherry()
    {
        GameObject cherry = Instantiate(cherryPrefab) as GameObject;
    }

    IEnumerator cherrySpawner()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(10.0f);
            spawnCherry();
              
        }
       
    }
}
