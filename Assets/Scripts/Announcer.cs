using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcer : MonoBehaviour
{
    public SoundManager soundManager;
    public void RandomizeSound(AudioSource audioSource)
    {
        float lowPitchRange = 0.85f;
        float highPitchRange = 1.0f;
        audioSource.pitch = Random.Range(lowPitchRange, highPitchRange);
        audioSource.volume = Random.Range(lowPitchRange,highPitchRange);

    }

    public void LockIn()
    {
        soundManager.announcer.clip = soundManager.annLockin;
        soundManager.announcer.Play();
    }

    public void Win()
    {

    }

    public void Loss()
    {

    }

    public void PlayAgain()
    {

    }

    public void Quit()
    {

    }

    public void NoMoney()
    {

    }

    public void WinStreak()
    {

    }
}
