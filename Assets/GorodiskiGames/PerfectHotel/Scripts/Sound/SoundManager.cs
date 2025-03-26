using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Level.Player;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip footStep;
    [SerializeField] private AudioClip cashCollect;
    [SerializeField] private AudioClip cashRemove;
    [SerializeField] private AudioSource audioSource;
    private AudioSource walkAudioSource;
    private AudioSource cashRemoveAudioSource;

    private void Awake()
    {
        EventUtility.OnPlayerWalkState += PlayPlayerWalkSound;
        EventUtility.OnPlayerCollectCash += PlayCashCollectSound;
        EventUtility.OnCashRemove += PlayCashRemoveSound;

        walkAudioSource = transform.GetChild(0).transform.Find("CashCollect").GetComponent<AudioSource>();
        cashRemoveAudioSource = transform.GetChild(0).transform.Find("CashRemove").GetComponent<AudioSource>();
    }

    void Start()
    {
        if (walkAudioSource && cashRemoveAudioSource != null)
        {
            Debug.Log(" IT IS NOT NULL :");
        }
    }

    private void PlayPlayerWalkSound(bool isWalking) 
    {
        if (isWalking)
        {
            audioSource.clip = footStep;
            audioSource.Play();
            Debug.Log("yes player is walking : yes");
        }
        else { Debug.Log("yes player is walking : no");

            audioSource.clip = null;
            audioSource.Stop();
        }

    }

    private void PlayCashCollectSound()
    {
        //cash collect
    
        if (walkAudioSource != null)
        {
            Debug.Log("PlayCashCollectSound is not null : ");
            walkAudioSource.clip = cashCollect;
            walkAudioSource.Play();
        }
    }

    private void PlayCashRemoveSound(bool isPlaying)
    {
        if (isPlaying)
        {
            if (!cashRemoveAudioSource.isPlaying)
            {
                cashRemoveAudioSource.clip = cashRemove;
                cashRemoveAudioSource.Play();
                Debug.Log("Cash removed sound play : PLAY");
            }
        }
        else
        {
            cashRemoveAudioSource.Stop();
            Debug.Log("Cash removed sound play : STOP");
        }
        

    }

}
