using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySnowball : MonoBehaviour
{


    void OnTriggerEnter(){
    if (gameObject.tag == "SnowBall"){
            gameObject.SetActive(false);
        }
    }
}
