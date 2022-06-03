using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testeatomico : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cube, new Vector3(-48.66f,20.52f,1.38f), Quaternion.identity);
    }
}
// Nao deixe rodar por mais de 30 minutos.
//e serio
//se vc quer que o pc exploda, vai fundo
//mas de vdd, roda por mais q isso nao
//pedindo na honestidade mesmo
//se rodar vai tomar um pau maluco
//mas agora serio mesmo, roda no maximo 30 segundos.
