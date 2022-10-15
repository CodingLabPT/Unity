using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    // float recebe numeros com virgulas. Ex: 10.25, 13.54, -0.5 etc
    [SerializeField]
    private float velocity = 10;

    // int - apenas sao perminutos numeros inteiros. Ex: 0, 10, -50 etc
    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // vector 3 (x, y, z)
        transform.Translate(new Vector3(x, 0, z) * velocity * Time.deltaTime);
    }
}

//Visibilidade
//public - qualquer script pode aceder as propriedades publicas do metodo que for publico
/* private - so dentro do limite do metodo (scopo) - dentro das chaves posso 
 * manipular as propriedades do objeto referido
 */

/*
 comentarios
 */
//comentários de apenas uma linha;
/*
 comentários de várias linhas
 */

/*
 convenções:
PascalCase - primeira letra de cada palavra escrita em maisculo: Ex: MoveCube;
camelCase / snakeCase - primeira letra minuscula e restantes iniciais das palavras maisculas: Ex: moveCube;
underscore_case - palavras são separadas por underscore: Ex: move_cube;

 */