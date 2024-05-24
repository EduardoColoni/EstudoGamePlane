using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
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
    [SerializeField] private Text textoLevel;

    //Inicializando sistemas de level
    private int level = 1;
    [SerializeField] private float proximoLevel= 10f;

    [SerializeField] private AudioClip levelUp;
    [SerializeField] private Vector3 camPos;
    // Start is called before the first frame update
    
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Pontos();
        CriandoObstaculos();
        GanhaLevel();
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
            timer = Random.Range(tMin / level, tMax);

            //Fazendo com que a posição seja aleatória
            posicao.y = Random.Range(posMin, posMax);

            //Criando meus obstaculos
            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
    private void GanhaLevel()
    {
        if (pontos > proximoLevel)
        {
            AudioSource.PlayClipAtPoint(levelUp, camPos);
            level++;
            proximoLevel *= 2;
        }
        textoLevel.text = Mathf.Round(level).ToString();
    }

    public int RetornaLevel()
    {
        return level;
    }

}
