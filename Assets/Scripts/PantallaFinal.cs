using UnityEngine;
using TMPro;

public class PantallaFinal : MonoBehaviour
{
    //Agregamos variables
    [SerializeField]
    GameObject pantallaFinal;
    [SerializeField]
    TextMeshProUGUI textLabelTime;

    //Partimos de tiempo 0
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            //Vamos sumando el tiempo
            tiempoDePartida = tiempoDePartida + Time.deltaTime;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ha llegado a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoCaracol>().enabled = false;
            //Tiempo se para y convertimos el valor en texto para que se muestre
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();

        }

    }
}
