using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golEsquerdo;
    public Placar placar;
    public Bola bola;
    public AudioSource somGol;
    private void OnTriggerEnter2D(Collider2D colisaoBola)
    {
        if (golEsquerdo)
        {
            placar.GolAzul();
        }
        else
        {
            placar.GolRosa();
        }
        somGol.Play();
        bola.VoltaProInicio();
    }
}
