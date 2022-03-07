using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour
{
    //Audio Source
    AudioSource fuenteDeAudio;

    //Clip de audio
    public AudioClip audioInicio;


    // Start is called before the first frame update
    void Start()
    {
        //Recupero el componente audio source;
        fuenteDeAudio = GetComponent<AudioSource>();

        //Reproduzco el sonido de la raqueta
        fuenteDeAudio.clip = audioInicio;
        fuenteDeAudio.Play();
    }

}
