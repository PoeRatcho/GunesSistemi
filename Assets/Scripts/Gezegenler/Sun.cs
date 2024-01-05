using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float rotationSpeed = 10f; // Döndürme hýzý

    void Update()
    {
        // Y ekseni etrafýnda dönme
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}












