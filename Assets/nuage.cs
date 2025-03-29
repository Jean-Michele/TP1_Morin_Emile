using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuage : MonoBehaviour
{
    [SerializeField] private GameObject _Nuage;
    [SerializeField] private GameObject _Tempete;
    // Start is called before the first frame update

    void OnTriggerEnter(){
    if (gameObject.tag == "Tracteur"){
            _Tempete.SetActive(true);
            Debug.Log("a");
            Invoke("disparaitre", 3.0f);
            _Nuage.SetActive(false);
        }
    }

    void disparaitre()
    {
        _Tempete.SetActive(false);
        Debug.Log("b");
    }
}
