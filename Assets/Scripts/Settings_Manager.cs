using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings_Manager : MonoBehaviour
{
    public GameObject startScreenCanvas;

    public SpriteRenderer textureManager; 
    public Transform[] buttons;
    
    public void Start()
    {
	foreach(var btn in buttons) {
	    var sprite = btn.GetComponentInChildren<SpriteRenderer>().sprite;
	    Debug.Log(sprite);
	    btn.GetComponent<Button>().onClick.AddListener(
		() => {textureManager.sprite = sprite;}
	    );
	}
    }

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
}

