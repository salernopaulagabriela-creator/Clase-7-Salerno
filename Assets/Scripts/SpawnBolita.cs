using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBolita : MonoBehaviour
{
    [SerializeField] GameObject bolitaPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 posicionMouse = Input.mousePosition;
            Vector3 posicionMouseMundo = Camera.main.ScreenToWorldPoint(posicionMouse);
            posicionMouseMundo.z = 0f;

            Instantiate(bolitaPrefab, posicionMouseMundo, Quaternion.identity);
        }
    }
}
