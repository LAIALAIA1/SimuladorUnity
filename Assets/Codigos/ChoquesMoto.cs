using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoquesMoto : MonoBehaviour
{
    AudioSource audioColisiones;
    [SerializeField]
    AudioClip golpeCarro;
    [SerializeField]
    AudioClip golpePed;
    [SerializeField]
    AudioClip golpeObjeto;
    void Start()
    {
        audioColisiones = GetComponent<AudioSource>();
    }

    public void GolpeConCarro() 
    {
        audioColisiones.volume = 1f;
        audioColisiones.clip = golpeCarro;
        StartCoroutine(golpe(audioColisiones));
    }

    public void GolpeConPersona()
    {
        audioColisiones.volume = 1f;
        audioColisiones.clip = golpePed;
        StartCoroutine(golpe(audioColisiones));
    }

    public void GolpeObjeto() {
        audioColisiones.volume = 0.3f;
        audioColisiones.clip = golpeObjeto;
        StartCoroutine(golpe(audioColisiones));
    }

    private IEnumerator golpe(AudioSource audio) {
        yield return new WaitWhile(() => audio.isPlaying);
        audio.Play();
    }
}
