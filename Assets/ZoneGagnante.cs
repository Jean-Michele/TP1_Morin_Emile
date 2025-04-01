using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneGagnante : MonoBehaviour
{

void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("Untagged")) {
        SceneManager.LoadScene(3);
    }
}
}
