using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{

    public float rotationSpeed = 200f; // Döndürme hýzý

    void Update()
    {
        // Y ekseni etrafýnda kendi etrafýnda dönme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Güneþ etrafýnda döndürme
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
