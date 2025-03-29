using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystal : MonoBehaviour
{

void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("Tracteur")) {
        Destroy(other.gameObject);
    }
}
}
