using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moon : MonoBehaviour
{

    public float rotationSpeed = 25f; // Döndürme hýzý

    void Update()
    {
        // Y ekseni etrafýnda kendi etrafýnda dönme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Güneþ etrafýnda döndürme
        transform.RotateAround(Vector3.zero, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}