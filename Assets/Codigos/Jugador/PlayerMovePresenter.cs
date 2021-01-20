using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePresenter : MonoBehaviour
{
    [SerializeField]
    private PlayerMoveModel model;

    [SerializeField]
    private PlayerMoveView view;

    private bool rightDirectional;
    private bool leftDirectional;
    private bool frenar;
    private bool cornet;
    private string luces;
    private int cambio;
    private float speedVehicle;
    public bool Cornet
    {
        get { return cornet; }
        set
        {
            if (value != cornet)
            {
                cornet = value;
                CornetChange(value);
            }
        }
    }

    public bool Frenar {
        get { return frenar; }
        set {
            if (value != frenar) {
                frenar = value;
                FrenarChange(value);
            }
        }
    }

    public bool RightDirectional { 
        get { return rightDirectional; } 
        set {
            if (value != rightDirectional)
            {
                RightDirectionalChange(value);
                rightDirectional = value;
            }
            else return;
        } 
    }
    public bool LeftDirectional { 
        get { return leftDirectional; } 
        set {
            if (value != leftDirectional)
            {
                LeftDirectionalChange(value);
                leftDirectional = value;
            }
            else return;
        } 
    }

    public string Luces { get { return luces; } set => luces = value; }

    private void Start()
    {
        rightDirectional = false;
        leftDirectional = false;
        LeftDirectionalChange(leftDirectional);
        RightDirectionalChange(rightDirectional);
        speedVehicle = 0f;
    }
    public void Joestick(Vector2 joestick) {
        model.MovePlayer(joestick);
       
    }
    public void FrenarChange(bool frenar) {
        model.Frenar(frenar);
        if (frenar) view.FrenarOn();
        else view.FrenarOff();
    }

    public void CornetChange(bool value)
    {
        model.Cornet(value);
        if (cornet) view.CornetOn();
        else view.CornetOff();
    }
    public void CambioChange(int value) 
    {
        view.setCambio(value);
        cambio = value;
    }
    public void ShowAccelerometer(float angle) {
        view.showAccelerometer(angle);
    }
    public float EvalueVelocity(float joeY, float speed, bool frenar) {
        float send;
        float tempSpeed =0f;
       
        switch (cambio) {
            case 0:
                tempSpeed = 0f;
                break;
            case 1:
                tempSpeed = map(joeY, 0f,1f, 0, 0.3f);
                break;
            case 2:
                if (speed > 0.5f)
                    tempSpeed = map(joeY, 0f, 1f, 0.3f, 0.5f);
                break;
            case 3:
                if (speed > 0.5f)
                    tempSpeed = map(joeY, 0f, 1f, 0.5f, 0.75f);
                break;
            case 4:
                if(speed>0.5f)
                    tempSpeed = map(joeY, 0f, 1f, 0.75f, 1f);
                break;
        }
        
        tempSpeed = map(tempSpeed, 0f, 1f, 0, 60f);
        if (speed < tempSpeed && frenar)
            tempSpeed = speed;
        speedVehicle = tempSpeed;


        send = map(speedVehicle *2,0f,60f,-45f,70f);
        ShowAccelerometer(send);

        return speedVehicle;
    }

    public void RightDirectionalChange(bool value) {
        rightDirectional = value;
        model.RightDirectional = value;
        if (rightDirectional)
        {
            view.RightDirectionalOn();
            if (leftDirectional)
            {
                leftDirectional = false;
                model.LeftDirectional = false;
                view.LeftDirectionalOff();
            }
        }
        else {
            view.RightDirectionalOff();
        }
    }

    public void LeftDirectionalChange(bool value)
    {
        leftDirectional = value;
        model.LeftDirectional = value;
        if (leftDirectional)
        {
            view.LeftDirectionalOn();
            if (rightDirectional)
            {
                rightDirectional = false;
                model.RightDirectional = false;
                view.RightDirectionalOff();
            }
        }
        else
        {
            view.LeftDirectionalOff();
        }
    }

    public void irAInicio() {model.irAInicio();}

    public void RepetirExperiencia() { model.RepetirExperiencia(); }

    float map(float s, float a1, float a2, float b1, float b2)
    {
        return b1 + (s - a1) * (b2 - b1) / (a2 - a1);
    }
}