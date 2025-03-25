using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Level.Player;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip footStep;
    [SerializeField] private AudioClip cashCollect;
    [SerializeField] private AudioSource audioSource;
    private AudioSource walkAudioSource;

    private void Awake()
    {
        EventUtility.OnPlayerWalkState += PlayPlayerWalkSound;
        EventUtility.OnPlayerCollectCash += PlayCashCollectSound;
        walkAudioSource = GameObject.Find("CashCollect").GetComponent<AudioSource>();
    }

    void Start()
    {
        
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

}
