using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreerBouleDeNeige : MonoBehaviour
{
    [SerializeField] GameObject _BouleDeNeige;
    [SerializeField] GameObject _CreerBouleDeNeige;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        float randomValeur = Random.Range(5, 10);
        InvokeRepeating("creer", randomValeur, randomValeur);
    }
        
        
    void creer()
    {
        Instantiate(_BouleDeNeige, _CreerBouleDeNeige.transform.position, _CreerBouleDeNeige.transform.rotation);
    }
}
