using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // velocidade de movimento do personagem
    private Rigidbody rb; // componente Rigidbody do personagem

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal"); // Entrada do eixo horizontal
        float moveZ = Input.GetAxis("Vertical"); // Entrada do eixo vertical
        rb.velocity = new Vector3(moveX * moveSpeed, 0, moveZ * moveSpeed); // atualiza a velocidade do personagem
    }
}