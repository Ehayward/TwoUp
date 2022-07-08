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
        soundManager.announcer.clip = soundManager.annLockIn[Random.Range(0, soundManager.annLockIn.Length)];
        soundManager.announcer.Play();
    }

    public void Win()
    {
        soundManager.announcer.clip = soundManager.annWin;
        soundManager.announcer.Play();
    }

    public void BigWin()
    {
        soundManager.announcer.clip = soundManager.annBigWin;
        soundManager.announcer.Play();
    }
    public void Loss()
    {
        soundManager.announcer.clip = soundManager.annLoss;
        soundManager.announcer.Play();
    }
    public void BigLoss()
    {
        soundManager.announcer.clip = soundManager.annBigLoss;
        soundManager.announcer.Play();
    }

    public void PlayAgain()
    {
        soundManager.announcer.clip = soundManager.annPlayAgain;
        soundManager.announcer.Play();
    }

    public void Quit()
    {
        soundManager.announcer.clip = soundManager.annQuit;
        soundManager.announcer.Play();
    }

    public void NoMoney()
    {
        soundManager.announcer.clip = soundManager.annNoMoney;
        soundManager.announcer.Play();
    }

    public void WinStreak()
    {
        soundManager.announcer.clip = soundManager.annWinStreak;
        soundManager.announcer.Play();
    }
}
