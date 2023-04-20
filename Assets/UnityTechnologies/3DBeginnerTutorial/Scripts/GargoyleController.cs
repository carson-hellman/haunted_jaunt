//source for how quaternion worked https://vionixstudio.com/2022/06/16/unity-quaternion-and-rotation-guide/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleController : MonoBehaviour
{
    public GameObject playerObject;
    public float rotationSpeed = 100.0f; //speed of rotation

    void Update()
    {
        // gets the position of each john lemon and gargoyle
        Vector3 playerPostion = playerObject.transform.position;
        Vector3 gargoylePostion = transform.position;
        
        // gets vector pointing from gargoyle to john lemon
        Vector3 lookVector = playerPostion - gargoylePostion;

        //finds the angle between the gargoyle's forward vector and the look vertor using 
        //dot product to determine how much the gargoyle needs to rotate
        float directionAngle = Mathf.Acos(Vector3.Dot(transform.forward, lookVector.normalized)) * Mathf.Rad2Deg;

        //uses quaternion.lerp in order to rotate the gargoyle towards jon lemon
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(lookVector), Time.deltaTime * rotationSpeed);
    }
}
