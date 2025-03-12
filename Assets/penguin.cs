using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penguin : MonoBehaviour
{

    [SerializeField] Rigidbody _Tracteur;
     private void OnCollisionEnter(Collision other){
    if (gameObject.tag == "Untagged"){
           _Tracteur.AddForce(-1000000, -1000000, 0, ForceMode.Impulse);
        }
    }
}
