using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreerCrystal : MonoBehaviour
{
    [SerializeField] GameObject _Crystal;
    [SerializeField] GameObject _CreerCrystal;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        float randomValeur = Random.Range(5, 10);
        InvokeRepeating("creer", randomValeur, randomValeur);
    }
        
        
    void creer()
    {
        Instantiate(_Crystal, _CreerCrystal.transform.position, _CreerCrystal.transform.rotation);
    }
}
