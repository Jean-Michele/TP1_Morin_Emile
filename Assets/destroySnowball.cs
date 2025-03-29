using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySnowball : MonoBehaviour
{

void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("SnowBall")) {
        Destroy(other.gameObject);
    }
}
}
