using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BgmPref = "BgmPref";
    private static readonly string SfxPref= "SfxPref";
    private int firstPlayInt;
    private float bgmFloat, sfxFloat;

    public AudioSource bgmAudio;
    public AudioSource sfxAudio;
    public Slider bgmSlider, sfxSlider;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        
        if (firstPlayInt == 0)
        {
            bgmFloat = .125f;
            sfxFloat = .75f;

            bgmSlider.value = bgmFloat;
            sfxSlider.value = sfxFloat;

            PlayerPrefs.SetFloat(BgmPref, bgmFloat);
            PlayerPrefs.SetFloat(SfxPref, sfxFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            bgmFloat = PlayerPrefs.GetFloat(BgmPref);
            bgmSlider.value = bgmFloat;
            sfxFloat = PlayerPrefs.GetFloat(SfxPref);
            sfxSlider.value = sfxFloat;
        }
    }

    public void SaveSoundSetting()
    {
        PlayerPrefs.SetFloat(BgmPref, bgmSlider.value);
        PlayerPrefs.SetFloat(SfxPref, sfxSlider.value);
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus)
        {
            SaveSoundSetting();
        }
    }

    public void UpdateSound()
    {
        bgmAudio.volume = bgmSlider.value;
        sfxAudio.volume = sfxSlider.value;

        /*
         * Uncomment jika pakai array
        for (int i = 0; i < sfxAudio.Length; i++)
        {
            sfxAudio[i].volume = sfxSlider.value;
        }
        */
    }

    public void sfxButton()
    {

        sfxAudio.Play();
    }

}
