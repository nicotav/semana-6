using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text textoGanador;

    public bool reiniciar = false;

    public void Setup(string ganador){

        gameObject.SetActive(true);
        textoGanador.text = "Ganador >> " + ganador.ToString();
        reiniciar = true;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Juego");
            Time.timeScale = 1;
        }
    }
}
