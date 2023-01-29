using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisao : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Verde")
        {
            /* o inimigo de tag verde "atira" o player para trás */
            rb.AddForce(collision.impulse * 3000);
        }

        if (collision.gameObject.tag == "Vermelha")
        {
            /* destroi o inimigo de tag vermelha */
            Destroy(collision.gameObject);
        }
    }

}
