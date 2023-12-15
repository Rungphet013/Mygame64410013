using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    
    void OncallisonEnter2D(Collision2D other)
    {
       Debug.Log("โอ๊ย"); 
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collision2D other)
    {
        Debug.Log("Rungphet");
    }
}
