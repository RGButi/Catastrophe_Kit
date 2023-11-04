using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Image On;
    [SerializeField] Image Off;
    private bool muted = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
        }
        else
        {
            load();
        }

        Updatepress();
        AudioListener.pause = true;
    }

    public void SoundPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        save();
        Updatepress();
    }

    private void Updatepress()
    {
        if (muted == false)
        {
            On.enabled = true;
            Off.enabled = false;
        }
        else
        {
            On.enabled = false;
            Off.enabled = true;
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }


}
