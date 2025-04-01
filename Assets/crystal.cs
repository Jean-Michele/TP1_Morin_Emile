using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class crystal : MonoBehaviour
{
    [SerializeField] GameObject _Tracteur;

void OnColliderEnter(Collider other){
    if (gameObject.CompareTag("Tracteur")) {
        Destroy(_Tracteur);
    }
}
}
