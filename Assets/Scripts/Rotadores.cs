using UnityEngine;

public class Rotadores : MonoBehaviour
{
    //Observar en el insector
    [SerializeField]
    //Añadimos velocidad de rotación
    float rotacionY = 100f;

    void Update()
    {
        //Rotar el objeto en el eje Y cada frame
        transform.Rotate(0f, rotacionY * Time.deltaTime, 0f);
    }
}