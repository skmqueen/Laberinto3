using UnityEngine;
using UnityEngine.SceneManagement;
public class Empezar : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
