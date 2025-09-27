using UnityEngine;

public class MovimientoCaracol : MonoBehaviour
{
    public float velocidadMovimiento = 1f;

    void Update()
    {
        float movimientoEjeX = Input.GetAxisRaw("Horizontal");
        float movimientoEjeZ = Input.GetAxisRaw("Vertical");

        Vector3 movimiento = new Vector3(movimientoEjeX, 0, movimientoEjeZ);

        if (movimiento != Vector3.zero)
        {
            //Rotaciones de Misifú
            if (Input.GetKey(KeyCode.W))
                transform.rotation = Quaternion.Euler(0, -90, 0);
            else if (Input.GetKey(KeyCode.A))
                transform.rotation = Quaternion.Euler(0, 180, 0);
            else if (Input.GetKey(KeyCode.S))
                transform.rotation = Quaternion.Euler(0, 90, 0);
            else if (Input.GetKey(KeyCode.D))
                transform.rotation = Quaternion.Euler(0, 0, 0); // puedes ajustar a tu gusto

            //Evitar santos en el espacio
            transform.position += movimiento.normalized * velocidadMovimiento * Time.deltaTime;
        }
    }
}
