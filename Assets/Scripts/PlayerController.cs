using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Pegando as informa��es do player/Criando as var�iveis
    private Rigidbody2D meuRB;

    //Minha velocidade
    [SerializeField] private float velocidade = 5;

    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Subir();
        LimitandoVelocidade();
    }

    private void LimitandoVelocidade()
    {
        //Limitando a minha velocidade de queda
        if (meuRB.velocity.y < -velocidade)
        {
            //Travando meuRB.velocity em -5
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    private void Subir()
    {
        //Subindo ao apertar espa�o
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;
        }
    }
}
