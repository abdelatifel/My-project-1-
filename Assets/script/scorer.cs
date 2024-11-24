using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    // Start is called before the first frame update

    int hits =0;

    private void OnCollisionEnter(Collision other)
     {
        if(other.gameObject.tag !="Hit")
        {
            hits++;
            Debug.Log("u have pomped many times:" + hits);

        }
        
     
        
    }
    
}
