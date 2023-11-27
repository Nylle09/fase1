using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAudioControler : MonoBehaviour
{
    public AudioSource audioSourceMusicadeFundo;
    public AudioClip[] musicasdefundo;
    void Start()
    {
        
       AudioClip musicaDEFundoDessaFase = musicasdefundo[0];
       audioSourceMusicadeFundo.clip = musicaDEFundoDessaFase;
       audioSourceMusicadeFundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
