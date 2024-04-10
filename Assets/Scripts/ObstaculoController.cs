using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float velocidade = 5;

    [SerializeField] private GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(obstaculo, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        MovimentoObstaculo();
    }

    //Criando o movimento para os meus obstaculos
    private void MovimentoObstaculo()
    {
        transform.position += Vector3.left * (Time.deltaTime * velocidade);
    }
}
