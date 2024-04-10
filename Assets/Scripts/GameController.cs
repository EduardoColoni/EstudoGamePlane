using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Timer
    private float timer= 1f;

    //Meu obstaculo
    [SerializeField] private GameObject obstaculo;

    //Posi��o para criar o obstaculo
    [SerializeField] private Vector3 posicao;

    //Posi��o m�nima e maxima
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
        //Diminuindo o valor de timer at� 
        timer -= Time.deltaTime;
        //Checando se o valor chegou em zero
        if(timer < 0f)
        {
            //Deixando o valor de tempo aleat�rio
            timer = Random.Range(tMin, tMax);

            //Fazendo com que a posi��o seja aleat�ria
            posicao.y = Random.Range(posMin, posMax);

            //Criando meus obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
