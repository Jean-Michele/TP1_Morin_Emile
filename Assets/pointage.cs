using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pointage : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _pointage;

    public static int pointageJeu = 0;

    void Start()
    {
        Pointage.pointageJeu = 1000;
        InvokeRepeating("pointage", 0f, 1f);
    }

    void Update()
    {
        _pointage.text = "SCORE: " + pointageJeu.ToString();

        if(pointageJeu == 0){
            SceneManager.LoadScene(2);
        }
    }

    void pointage()
    {
        pointageJeu -= 10;
    }
}
