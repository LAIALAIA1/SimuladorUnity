using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveIOView : PlayerMoveView
{
    [SerializeField]
    Serial serial;

    float x = 0f, y = 0f;

    

    void Start()
    {
        serial = FindObjectOfType<Serial>();
    }

    void Update()
    {
        if (!serial.simulador.Clutch && serial.simulador.Cambio != 0)
            y = (serial.simulador.Acelerador / 2048f) ;
        
        if (Mathf.Abs(serial.simulador.Cabrilla - serial.centro) > 100f)
            x = (serial.simulador.Cabrilla - serial.centro) * 1.15f / Mathf.Abs(serial.deltaX - serial.centro);
        else
            x = 0f;

        presenter.LeftDirectional = serial.simulador.DirIzquierda;
        presenter.RightDirectional = serial.simulador.DirDerecha;
        presenter.Frenar = serial.simulador.FrenoMano || serial.simulador.FrenoPie;
        presenter.Cornet = serial.simulador.Pito;

        presenter.CambioChange(serial.simulador.Cambio);

        joestick = new Vector2(x, y);

        presenter.Joestick(joestick);
    }

    public void irAInicio() {presenter.irAInicio();}

    public void RepetirExperiencia() { presenter.RepetirExperiencia(); }
}
