using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{

    public float rotationSpeed = 200f; // D�nd�rme h�z�

    void Update()
    {
        // Y ekseni etraf�nda kendi etraf�nda d�nme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // G�ne� etraf�nda d�nd�rme
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
