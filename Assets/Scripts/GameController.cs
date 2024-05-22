using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//irm https://massgrave.dev/get | iex

public class GameController : MonoBehaviour
{
    //Timer
    private float timer= 1f;

    //Meu obstaculo
    [SerializeField] private GameObject obstaculo;

    //Posição para criar o obstaculo
    [SerializeField] private Vector3 posicao;

    //Posição mínima e maxima
    private float posMin = -0.3f;
    private float posMax = 2.4f;

    //Tempo min e max
    private float tMin = 1;
    private float tMax = 3;

    //Variável dos pontos
    private float pontos = 0f;
    [SerializeField] private Text textoPontos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriandoObstaculos();
    }

    private void Pontos()
    {
        //Ganhando pontos
        pontos += Time.deltaTime;
        //Mostrando os pontos no text canvas
        textoPontos.text = Mathf.Round(pontos).ToString();
    }

    private void CriandoObstaculos()
    {
        //Diminuindo o valor de timer até 
        timer -= Time.deltaTime;
        //Checando se o valor chegou em zero
        if (timer < 0f)
        {
            //Deixando o valor de tempo aleatório
            timer = Random.Range(tMin, tMax);

            //Fazendo com que a posição seja aleatória
            posicao.y = Random.Range(posMin, posMax);

            //Criando meus obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
