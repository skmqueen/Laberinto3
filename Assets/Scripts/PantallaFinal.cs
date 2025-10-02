using UnityEngine;
using TMPro;

public class PantallaFinal : MonoBehaviour
{

    [SerializeField]
    GameObject pantallaFinal;
    [SerializeField]
    TextMeshProUGUI textLabelTime;

    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
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
            estaJugando = false;
            textLabelTime.text = tiempoDePartida.ToString();

        }

    }
}
