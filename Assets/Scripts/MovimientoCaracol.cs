using UnityEngine;

public class MovimientoCaracol : MonoBehaviour
{
    public float velocidadMovimiento = 1.5f;

    void Update()
    {
        // Lectura de input
        float movimientoEjeX = Input.GetAxisRaw("Horizontal");
        float movimientoEjeZ = Input.GetAxisRaw("Vertical");

        Vector3 direccion = new Vector3(movimientoEjeX, 0, movimientoEjeZ);

        if (direccion != Vector3.zero)
        {
            // Rotación instantánea hacia la dirección del movimiento
            transform.rotation = Quaternion.LookRotation(direccion);

            // Movimiento hacia adelante respecto a la nueva rotación
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }
    }
}
