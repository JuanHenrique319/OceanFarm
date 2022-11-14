using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMixerSCR : MonoBehaviour
{
    /// Descri��o 
    /// roda atrav�s de um array quantos audioclip eu quiser
    /// Descri��o 
    public bool playing;
    public AudioSource source;
    public AudioClip[] musicclips;
    void Start()
    {
        playing = true;
        StartCoroutine(Playmusicloop());
    }

    // Update is called once per frame
    IEnumerator Playmusicloop()
        //play em loop�de um vetor de clipes
    {
        yield return null;
        while (playing)
        {
            for(int i =0; i<musicclips.Length; i++)
            {
                source.clip = musicclips[i];
                source.Play();
                while (source.isPlaying)
                {
                    yield return null;
                }
            }
        }
    }
}
