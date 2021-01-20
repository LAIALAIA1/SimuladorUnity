using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsMobile : MonoBehaviour
{
    AudioSource audio;
    [SerializeField]
    AudioClip cornet;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Cornet()
    {
        audio.volume = 1f;
        audio.clip = cornet;
        StartCoroutine(play());
    }
    public void CornetStop() {
        audio.Stop();
    }
    private IEnumerator play()
    {
        yield return new WaitWhile(() => audio.isPlaying);
        audio.Play();
    }
}
