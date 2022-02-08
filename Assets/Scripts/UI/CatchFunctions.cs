using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject LeftPlatform;
    public GameObject MiddlePlatform;
    public GameObject RightPlatform;
    public bool activePlat = false;
    public AudioSource platActiveFX;

    public void LeftPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActiveFX.Play();
            LeftPlatform.SetActive(true);
            StartCoroutine(LeftReset());
        }
     }


    public void MidPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActiveFX.Play();
            MiddlePlatform.SetActive(true);
            StartCoroutine(MidReset());
        }
    }
    public void RightPlat()
    {
        if (activePlat == false)
        {
            activePlat = true;
            platActiveFX.Play();
            RightPlatform.SetActive(true);
            StartCoroutine(RightReset());
        }
    }
    IEnumerator LeftReset()
    {
        yield return new WaitForSeconds(0.5f);
        LeftPlatform.SetActive(false);
        activePlat = false;
    }
    IEnumerator MidReset()
    {
        yield return new WaitForSeconds(0.5f);
        MiddlePlatform.SetActive(false);
        activePlat = false;
    }
    IEnumerator RightReset()
    {
        yield return new WaitForSeconds(0.5f);
        RightPlatform.SetActive(false);
        activePlat = false;
    }
}
