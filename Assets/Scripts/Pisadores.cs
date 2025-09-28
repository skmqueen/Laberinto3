using UnityEngine;

public class Pisadores : MonoBehaviour
{
    [SerializeField] float velocidad = 1f; // Velocidad de movimiento
    [SerializeField] float distancia = 2f;  // Distancia máxima

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position; // Guardar posición inicial
    }

    void Update()
    {
        // Calcular nueva posición en el eje Z
        float desplazamiento = Mathf.PingPong(Time.time * velocidad, distancia);
        transform.position = posicionInicial + transform.forward * desplazamiento;
    }
}
