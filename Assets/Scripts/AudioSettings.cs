using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string BgmPref = "BgmPref";
    private static readonly string SfxPref = "SfxPref";
    private float bgmFloat, sfxFloat;

    public AudioSource bgmAudio;
    public AudioSource sfxAudio;

    private void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        bgmFloat = PlayerPrefs.GetFloat(BgmPref);
        sfxFloat = PlayerPrefs.GetFloat(SfxPref);

        bgmAudio.volume = bgmFloat;

        sfxAudio.volume = sfxFloat;

        /*
         * Uncomment jika pakai array
        for (int i = 0; i < sfxAudio.Length; i++)
        {
            sfxAudio[i].volume = sfxFloat;
        }
        */
    }

    public void sfxButton()
    {

        sfxAudio.Play();
    }
}
