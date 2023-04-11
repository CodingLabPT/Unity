using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float invincibilityTime = 3f; // Tempo de invencibilidade após colisão
    private int collidedTimes = 0;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verifica se a colisão foi com um objeto inimigo
        if (collision.gameObject.CompareTag("enemy"))
        {
            //collidedTimes = collidedTimes + 1;
            collidedTimes++;
            Debug.Log("Colliding " + collidedTimes + " times!!");
            //desabilita a fisica
            rb.isKinematic = true;
            Destroy(collision.gameObject);
            // chama uma outra funcao, de x em x segundos
            Invoke("DealDamage", invincibilityTime);
        }
    }

    private void Update()
    {
        // Movimentação horizontal e vertical do jogador
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, 0f, verticalInput) * Time.deltaTime * 5);
    }

    void DealDamage()
    {
        //habilita a fisica
        rb.isKinematic = false;
    }
}