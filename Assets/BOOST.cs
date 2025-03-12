using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOST : MonoBehaviour
{
    [SerializeField] Rigidbody _Tracteur;
    [SerializeField] GameObject _Shrooms;
    private void OnTriggerEnter(){
    if (gameObject.tag == "Untagged"){
            Destroy(_Shrooms);
           _Tracteur.AddForce(0, 0, 10000f, ForceMode.Impulse);
        }
    }
}
