using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMusicVolume : MonoBehaviour
{
    public List <AudioSource> sources = new List<AudioSource>();

    private void Start()
    {
        foreach (AudioSource source in sources)
        {
            if (PlayerPrefs.GetInt("volumeSet") == 1)
            {
                source.volume = PlayerPrefs.GetFloat("volume");
            }
        }
    }


}
