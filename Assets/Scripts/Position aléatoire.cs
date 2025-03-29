using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positionaléatoire : MonoBehaviour
{
    [SerializeField] private float _distanceMaximale;

    void Start()
    {
        Vector3 PoisitionX = Vector3.zero;
        Vector2 variation = Random.insideUnitCircle * _distanceMaximale;
        PoisitionX.x = variation.x;
        PoisitionX.z = variation.y;
        transform.position += PoisitionX;

        float rotationY = Random.Range(0f, 360f);
        transform.Rotate(0, rotationY, 0,Space.World);
    }
}
