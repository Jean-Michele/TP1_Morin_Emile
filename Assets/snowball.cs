using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snowball : MonoBehaviour
{
    [SerializeField] private Rigidbody _Tracteur;

private void OnCollisionEnter(Collision other){
    if (other.gameObject.tag == "SnowBall"){
           _Tracteur.AddForce(-1000000, -1000000, 0, ForceMode.Impulse);
           SceneManager.LoadScene(2);
       }    
    }


}
