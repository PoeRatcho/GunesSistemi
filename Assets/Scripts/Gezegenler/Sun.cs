using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float rotationSpeed = 10f; // D�nd�rme h�z�

    void Update()
    {
        // Y ekseni etraf�nda d�nme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}












