using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Placar : MonoBehaviour
{
    public int pontuacaoRosa;
    public int pontuacaoAzul;
    public TextMeshProUGUI placarRosa;
    public TextMeshProUGUI placarAzul;

    // Start is called before the first frame update
    void Start()
    {
        placarRosa.text = "0";
        placarAzul.text = "0";
    }

    public void GolRosa()
    {
        pontuacaoRosa++;
        placarRosa.text = pontuacaoRosa.ToString();
        Debug.Log("GOOOOL!! ÉÉÉÉÉÉ DA ROSA!!!");
    }

    public void GolAzul()
    {
        pontuacaoAzul++;
        placarAzul.text = pontuacaoAzul.ToString();
        Debug.Log("GOOOOL!! ÉÉÉÉÉÉ DO AZUL!!!");
    }
}

