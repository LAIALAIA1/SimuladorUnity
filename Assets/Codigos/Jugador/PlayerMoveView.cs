using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMoveView: MonoBehaviour 
{
    [SerializeField]
    protected PlayerMovePresenter presenter;

    [SerializeField]
    protected Text Cambio;

    [SerializeField]
    protected Image Aguja;

    [SerializeField]
    protected GameObject[] leftDirImg;

    [SerializeField]
    protected GameObject[] rightDirImg;

    [SerializeField]
    protected GameObject[] stopLights;

    [SerializeField]
    protected GameObject cornetImg;

    protected Vector2 joestick;

    protected bool frenar;
    protected bool cornet;
    protected bool rightDirectional;
    protected bool leftDirectional;

    private void Start()
    {
        foreach (GameObject ob in leftDirImg) {
            ob.SetActive(false);
        }
        foreach (GameObject ob in rightDirImg)
        {
            ob.SetActive(false);
        }
        rightDirectional = false;
        leftDirectional = false;
    }

    public void showAccelerometer(float angle) {
        Aguja.rectTransform.localEulerAngles =new Vector3(0f, 180f, angle);
    }

    public void FrenarOn() {
        frenar = true;
        StartCoroutine(frenarOnImg());
    }

    public void FrenarOff()
    {
        frenar = false;
    }

    public void CornetOn()
    {
        cornet = true;
        StartCoroutine(cornetOnImg());
    }

    public void CornetOff()
    {
        cornet = false;
    }

    public void setCambio(int cambio) 
    {
        Cambio.text = cambio.ToString();
    }

    public void RightDirectionalOn() {
        rightDirectional = true;
        StartCoroutine(rightDirectionalOnImg());
    }

    public void LeftDirectionalOn()
    {
        leftDirectional = true;
        StartCoroutine(leftDirectionalOnImg());
    }

    public void LeftDirectionalOff() {
        leftDirectional = false;
    }

    public void RightDirectionalOff()
    {
        rightDirectional = false;
    }

    IEnumerator leftDirectionalOnImg() {
        foreach (GameObject ob in leftDirImg)
        {
            ob.SetActive(true);
        }
        yield return new WaitForSeconds(.5f);
        StartCoroutine(leftDirectionalOffImg());
    }

    IEnumerator leftDirectionalOffImg()
    {
        foreach (GameObject ob in leftDirImg)
        {
            ob.SetActive(false);
        }
        yield return new WaitForSeconds(.5f);
        yield return new WaitUntil(() => leftDirectional);
        StartCoroutine(leftDirectionalOnImg());
    }
    IEnumerator rightDirectionalOnImg()
    {
        foreach (GameObject ob in rightDirImg)
        {
            ob.SetActive(true);
        }
        yield return new WaitForSeconds(.5f);
        StartCoroutine(rightDirectionalOffImg());
    }

    IEnumerator rightDirectionalOffImg()
    {
        foreach (GameObject ob in rightDirImg)
        {
            ob.SetActive(false);
        }
        yield return new WaitForSeconds(.5f);
        yield return new WaitUntil(() => rightDirectional);
        StartCoroutine(rightDirectionalOnImg());
    }

    IEnumerator frenarOnImg()
    {
        foreach (GameObject ob in stopLights)
        {
            ob.SetActive(true);
        }
        yield return new WaitWhile(()=>frenar);
        foreach (GameObject ob in stopLights)
        {
            ob.SetActive(false);
        }
    }

    IEnumerator cornetOnImg()
    {
        cornetImg.SetActive(true);
        yield return new WaitWhile(() => cornet);
        cornetImg.SetActive(false);
    }

}
