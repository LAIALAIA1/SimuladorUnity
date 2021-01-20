using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Serial : MonoBehaviour
{
    List<string> ports;
    SerialPort tempCom;
    SerialPort comPort;
    bool tempComValid;
    bool tempIsConnected;
    [SerializeField]
    bool isConnected;
    string tempComReceived;
    [SerializeField]
    string deviceName;

    public int centro;

    public int deltaX;
   
    public Simulador simulador;

    public bool DirDerecha = false;
    public bool DirIzquierda = false;
    

    public string DeviceName { get => deviceName; set => deviceName = value; }
    public bool IsConnected { get => isConnected; set => isConnected = value; }

    private void Start()
    {
        DontDestroyOnLoad(this);
        isConnected = false;
        tempIsConnected = false;
        tempComValid = false;
        SceneManager.LoadScene("inicio");
    }

    public void RefreshPorts() {
        isConnected = false;
        tempIsConnected = false;
        tempComValid = false;
        StartCoroutine(FindPorts());
    }

    private IEnumerator FindPorts() {
        ports = new List<string> { };
        foreach (string port in SerialPort.GetPortNames())
        {
            ports.Add(port);
            if (port != "COM1" && !isConnected)
            {
                StartCoroutine(OwnHandShake(port));
            }
            yield return new WaitForSeconds(1.3f);
        }
    }
    IEnumerator OwnHandShake(string port)
    {
        print(port);
        tempCom = ConfigPort(port);
        OpenPort(tempCom);
        tempIsConnected = true;
        tempComValid = false;
        try
        {
            SendMessageToEsp(tempCom, "BlackNoise");
        }
        catch { 
        
        }
        yield return new WaitForSeconds(1f);
        if (tempComValid)
        {
            comPort = tempCom;
            isConnected = true;
        }
        else
        {
            ClosePort(tempCom);
        }
    }

    public void AttemptConnection(SerialPort myPort)
    { 
        
    }

    private void Update()
    {
        if (tempIsConnected)
            try {
                tempComReceived = tempCom.ReadLine();
                
                string[] llegada = tempComReceived.Split(':');
                print(llegada[1]);
                if (llegada[0].Contains("Conected")) {
                    tempComValid = true;
                    deviceName = llegada[1];
                    tempIsConnected = false;
                }
            }
            catch(System.Exception) 
            {

            }
        if (isConnected) {
            try
            {
                comPort.DiscardInBuffer();
                string datos = comPort.ReadLine();
                if (datos != "" && datos.StartsWith("{"))
                {
                    datos = datos.Replace(" ", "");
                    //datos = datos.Replace("\"", "");
                    datos = datos.Replace("_", "");
                    //datos = JsonUtility.ToJson(datos);
                    //Debug.Log(datos);
                    simulador = JsonUtility.FromJson<Simulador>(datos);
                    //Debug.Log(simulador.Cabrilla);
                    DirDerecha = simulador.DirDerecha;
                    DirIzquierda = simulador.DirIzquierda;
                }
            }
            catch (System.Exception)
            {
                simulador = new Simulador();
            }


        }
    }

    private SerialPort ConfigPort(string portName)
    {
        SerialPort espPort = new SerialPort(portName);
        espPort.BaudRate = 115200;
        espPort.Parity = Parity.None;
        espPort.DataBits = 8;
        
        return espPort;
    }

   

    public void OpenPort(SerialPort espPort)
    {
        espPort.Open();
        espPort.ReadTimeout = 50;
    }
    public void SendMessageToEsp(SerialPort espPort, string msg) {
        espPort.WriteLine(msg);
    }
    public void ClosePort(SerialPort espPort) {
        espPort.Close();
    }

    public void CloseActualPort()
    {
        comPort.Close();
    }

    public void Centrar() 
    {
        centro = simulador.Cabrilla;
    }

    public void MaximoGiro()
    {
        deltaX = simulador.Cabrilla;
    }
}



[Serializable]
 public class Simulador
{
    // Variables Intermedias    
    public int Cabrilla;
    public int Acelerador;
    public bool Clutch;
    public bool FrenoPie;
    public bool FrenoMano;
    public bool DirDerecha = false;
    public bool DirIzquierda = false;
    public string Luces;
    public int Cambio;
    public bool Pito;

}