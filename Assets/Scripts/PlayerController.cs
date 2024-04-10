using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Pegando as informações do player/Criando as varáiveis
    private Rigidbody2D meuRB;
    private int minhaCena = 0;

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
        //Subindo ao apertar espaço
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Fazendo a velocidade do RB ir para cima
            meuRB.velocity = Vector2.up * velocidade;   
        }
    }
    //Checando se o colisor do avião encostou em outro colisor e resetando o jogo
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(minhaCena);
    }
}
