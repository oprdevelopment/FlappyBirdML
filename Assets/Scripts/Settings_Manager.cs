using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings_Manager : MonoBehaviour
{
    public GameObject startScreenCanvas;

    public FlappyBirdTextureManager textureManager; 
    public Sprite[] availableSprites;
    
    public void TurnOnSettingMenu()
    {
        startScreenCanvas.SetActive(false);
        gameObject.SetActive(true);
    }

    public void SoundOn()
    {
        AudioListener.volume = 1;
    }

    public void SoundOff()
    {
        AudioListener.volume = 0;
    }

    public void ChangeTexture(int index)
    {
        if (index >= 0 && index < availableSprites.Length)
        {
            textureManager.ChangeSprite(index);
        }
    }
}

