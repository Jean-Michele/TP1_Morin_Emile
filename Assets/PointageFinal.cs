using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointageFinal : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _pointage;
    private int pointageFinal = Pointage.pointageJeu;
    void Start()
    {
        _pointage.text = "SCORE: " + pointageFinal.ToString();
    }
}
