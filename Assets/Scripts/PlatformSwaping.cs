using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSwaping : MonoBehaviour
{
    public GameObject platform;
    public float swapTime = 1f;
    private float nextSwaptime;


    void Start()
    {
      //  currentSwaptime = swapTime;
        
    }

    void Update()
    {
        if(nextSwaptime <= Time.time)
        {
            swap();
            nextSwaptime = Time.time + swapTime;
        }
    }
    void swap()
    {
        Vector3 temp = transform.position;
        temp.x = Random.Range(1.7f, -1.7f);
        Instantiate(platform, temp, Quaternion.identity);
          
    
         

    }
}
