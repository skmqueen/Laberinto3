using UnityEngine;

public class MovimientoCaracol : MonoBehaviour
{
    public float velocidadMovimiento = 1f;

    void Update()
    {
        // Lectura de input
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(inputX, 0, inputZ);

        if (direccion != Vector3.zero)
        {
            // Normalizamos la dirección para evitar mayor velocidad en diagonal
            direccion = direccion.normalized;

            // Rotaciones instantáneas según tecla
            if (Input.GetKey(KeyCode.W))
                transform.rotation = Quaternion.Euler(0, -90, 0);
            else if (Input.GetKey(KeyCode.A))
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else if (Input.GetKey(KeyCode.S))
                transform.rotation = Quaternion.Euler(0, 90, 0);
            else if (Input.GetKey(KeyCode.D))
                transform.rotation = Quaternion.Euler(0, 0, 0);

            // Movimiento
            transform.Translate(direccion * velocidadMovimiento * Time.deltaTime, Space.World);
        }
    }
}
