using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Diminuindo o valor de timer até 
        timer -= Time.deltaTime;
        //Checando se o valor chegou em zero
        if(timer < 0f)
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
