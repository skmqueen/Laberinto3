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
            tiempoEnRojo -= Time.deltaTime; // resta el tiempo en segundos, de ahí el -=

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

    // Se ejecuta cuando otro objeto colisiona con este
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            // Cambia el material de la pared al rojo
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredRoja = true;
        }
    }
}
