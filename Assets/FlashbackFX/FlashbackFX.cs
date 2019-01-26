using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using seyahdoo.fading;


public class FlashbackFX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fader.CreateFaderInstance();
    }

    public bool test = false;

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            test = false;
            DoFlashback();
        }


    }


    public void DoFlashback()
    {


    }


}
