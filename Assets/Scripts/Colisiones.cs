using UnityEngine;

public class Colisiones : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRoja = false;
    float tiempoEnRojo = 3f;

    // Se ejecuta cada frame
    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo -= Time.deltaTime; // resta el tiempo en segundos reales

            if (tiempoEnRojo <= 0.0f)
            {
                // Volvemos al material por defecto
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;

                // Reiniciamos variables
                paredRoja = false;
                tiempoEnRojo = 3f;
            }
        }
    }

    // Se ejecuta cuando otro objeto colisiona con este GameObject
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            // Cambia el material de la pared al tocado
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;

            // Activamos el estado de pared roja
            paredRoja = true;
        }
    }
}
