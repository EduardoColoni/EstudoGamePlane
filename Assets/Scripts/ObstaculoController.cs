using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;

    [SerializeField] private GameObject obstaculo;

    [SerializeField] private GameController game;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(obstaculo, 5f);

        //Encontrando o game controller da cena atual
        game = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoObstaculo();
        velocidade = 4f + game.RetornaLevel();
    }

    //Criando o movimento para os meus obstaculos
    private void MovimentoObstaculo()
    {
        transform.position += Vector3.left * (Time.deltaTime * velocidade);
    }
}
