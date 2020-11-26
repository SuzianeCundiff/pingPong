using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D meuRigidbody2D;
    public Vector3 posInicial;
    public bool inicio;

    public AudioSource[] sons;

    private void Start()
    {
        inicio = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inicio == true)
        {
            LancaBola();
        }
    }

    public void VoltaProInicio()
    {
        inicio = true;
        meuRigidbody2D.velocity = Vector2.zero;
        transform.position = posInicial;
    }

    public void LancaBola()
    {
        inicio = false;
        // cobre o lado esquerdo do plano
        Vector2 direcao = new Vector2(Random.Range(0.2f, 1f), Random.Range(-1f, 1f)).normalized;
        bool sinalNegativo = Random.Range(0, 2) == 0;

        if (sinalNegativo == true)
        {
            direcao = -direcao;
        }

        meuRigidbody2D.velocity = direcao * velocidade;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int somAleatorio = Random.Range(0, sons.Length);

        sons[somAleatorio].Play();
    }

}
