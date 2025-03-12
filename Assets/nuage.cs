using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuage : MonoBehaviour
{
    [SerializeField] private GameObject _Nuage;
    [SerializeField] private GameObject _Tempete;
    // Start is called before the first frame update

    void OnTriggerEnter(){
    if (gameObject.tag == "Untagged"){
            _Tempete.SetActive(true);
            Destroy(_Nuage);
            Invoke("disparaitre", 3.0f);
        }
    }

    void disparaitre()
    {
        _Tempete.SetActive(false);
    }
}
