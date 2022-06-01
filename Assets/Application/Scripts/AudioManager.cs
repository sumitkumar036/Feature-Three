using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip touch;
    public AudioClip winClip;

    void Awake()
    {
        if(audioSource == null)
         audioSource = GetComponent<AudioSource>();
    }

     private void OnEnable () {
        ScriptableReference.clickedButton += ButtonIsTouched;
        GameManager.winnerIs += OnWin; //Subscribing winnerIs
    }

    private void OnDisable () {
        ScriptableReference.clickedButton -= ButtonIsTouched;
        GameManager.winnerIs -= OnWin; //Subscribing winnerIs
    }

    public void ButtonIsTouched(CardData noUse)
    {
        PlayAudio(touch);
    }

    public void OnWin(CardData noUse)
    {
        PlayAudio(winClip);
    }

    public void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
