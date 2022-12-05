using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AnimationFunctions : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public bool disableOnce;
    public GameObject mainMenu;
    public GameObject oldLogo;
    public GameObject music;
    public CinemachineVirtualCamera virtualCamera;
    public Animator animator;
    public GameObject player;
    public GameObject fakePlayer;
    public AudioSource SFX;
    public Animator kak;
    
    void PlaySound (AudioClip whichSound)
    {
        if (!disableOnce)
        {
            menuButtonController.audioSource.PlayOneShot (whichSound);
        } else
        {
            disableOnce = false;
        }
    }
    void SlashSound(AudioClip whichSound)
    {
        if (!disableOnce)
        {
            menuButtonController.audioSource.PlayOneShot(whichSound);
        }
        else
        {
            disableOnce = false;
        }
    }

    void EndCutscene()
    {
        mainMenu.SetActive (true);
        //oldLogo.SetActive (false);
        music.SetActive (true);
    }

    void CameraZoom()
    {
        animator.SetTrigger("StartZoom");
    }

    void PlayerPlay()
    {
        player.SetActive (true);
        fakePlayer.SetActive (false);
        music.SetActive (true);
    }

    void PlaySFX(AudioClip whichSound)
    {
        SFX.PlayOneShot (whichSound);
    }

    void Voidout()
    {
        kak.SetTrigger("FadeOut");
    }
}
