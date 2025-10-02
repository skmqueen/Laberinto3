using UnityEngine;

public class PantallaFinal : MonoBehaviour
{

    [SerializeField]
    GameObject pantallaFinal;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ha llegado a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoCaracol>().enabled = false;
        }

    }
}
