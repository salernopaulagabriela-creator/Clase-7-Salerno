using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBolita : MonoBehaviour
{
    [SerializeField] float velocidad;

    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * velocidad * Time.deltaTime);
    }
}