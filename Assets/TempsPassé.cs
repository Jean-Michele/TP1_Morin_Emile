using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TempsPassé : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _tempsPassé;

    public int tempsJeu = 0;

    void Start()
    {
        tempsJeu = 0;
        InvokeRepeating("Secondes", 0f, 1f);
    }

    void Update()
    {
        _tempsPassé.text = "Temps passé: " + tempsJeu.ToString() + " s";
    }

    void Secondes()
    {
        tempsJeu += 1;
    }
}
