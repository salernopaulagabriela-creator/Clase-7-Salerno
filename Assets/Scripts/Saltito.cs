using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltito : MonoBehaviour
{
    Rigidbody2D rigidbodyMio;
    [SerializeField] float fuerzaSalto = 5f;

    void Awake()
    {
        rigidbodyMio = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbodyMio.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}