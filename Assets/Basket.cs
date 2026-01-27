using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        // Move the basket with mouse
        // Get the current screen position of the mouse from Input
        
        // The Camera's z position sets how far to push the mouse into 3D
        // If this line causes a NullReferenceException, select the Main Camera
        // in the Hierarchy and set its tag to MainCamera in the Inspector.
        
        // Convert the point from 2D screen space into 3D game world space
        
        // Move the x position of this Basket to the x position of the Mouse
    }

    void OnCollisionEnter(Collision coll)
    {
        // Find out what hit this basket (CompareTag)
    }
}
