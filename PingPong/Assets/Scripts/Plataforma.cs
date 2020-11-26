using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public bool plataformaEsquerda;
    public Rigidbody2D meuRigidbody2D;
    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        if(plataformaEsquerda)
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.up;    
            }
            else if(Input.GetKey(KeyCode.DownArrow))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.down;
            }
            else
            {
                meuRigidbody2D.velocity = Vector2.zero;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.up;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                meuRigidbody2D.velocity = velocidade * Vector2.down;
            }
            else
            {
                meuRigidbody2D.velocity = Vector2.zero;
            }
        }
    }
}
