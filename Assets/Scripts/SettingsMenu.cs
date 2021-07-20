using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioSource SfxSource;

    private float musicVolume = 1f;
    private float sfxVolume = 1f;

    public void StartMusic()
        {
        MusicSource.Play();
        }

    public void StartSfx()
        {
        SfxSource.Play();
        }

    void Update()
        {
        MusicSource.volume = musicVolume;
        SfxSource.volume = sfxVolume;
        Debug.Log(musicVolume);
        Debug.Log(sfxVolume);
        PlayerPrefs.SetFloat("Music Volume", musicVolume);
        PlayerPrefs.SetFloat("SFX Volume", sfxVolume);
        PlayerPrefs.Save();
        }

    public void updateMusicVolume(float muvol)
        {
        musicVolume = muvol;
        }
    
    public void updateSfxVolume(float sfxvol)
        {
        sfxVolume = sfxvol;
        }
}
