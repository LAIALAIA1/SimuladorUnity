using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CanvasInitController : MonoBehaviour
{

    [SerializeField]
    Button buttonConectar;
    [SerializeField]
    Button buttonDesconectar;
    [SerializeField]
    Button buttonCalibrar;
    [SerializeField]
    Button buttonEmpezar;
    [SerializeField]
    Canvas principalCanvas;
    [SerializeField]
    Canvas calibrarCanvas;
    [SerializeField]
    Serial serial;

    [SerializeField]
    Toggle togglePito;

    [SerializeField]
    Toggle toggleClutch;

    [SerializeField]
    Toggle toggleFrenoMano;
    [SerializeField]
    Toggle toggleFrenoPie;
    [SerializeField]
    Toggle toggleDirDerecha;
    [SerializeField]
    Toggle toggleDirIzquierda;

    [SerializeField]
    Text textCambio;
    [SerializeField]
    Text textLuces;
    [SerializeField]
    Text textAcelerador;
    [SerializeField]
    Text textCabrilla;

    
    bool enCalibrar;

    private void Awake()
    {
        serial = FindObjectOfType<Serial>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
        buttonConectar.gameObject.SetActive( false);
        buttonDesconectar.gameObject.SetActive(false);
        buttonEmpezar.gameObject.SetActive(false);
        buttonCalibrar.gameObject.SetActive(false);
        if (serial.IsConnected)
        {
            buttonDesconectar.gameObject.SetActive(true);
            buttonEmpezar.gameObject.SetActive(true);
            buttonCalibrar.gameObject.SetActive(true);
        }
        else {
            buttonConectar.gameObject.SetActive(true);
            StartCoroutine(esperarConecxion());
        }
        enCalibrar = false;
    }

    IEnumerator esperarConecxion() {
        yield return new WaitUntil(() =>serial.IsConnected);
        
        buttonDesconectar.gameObject.SetActive(true);
        buttonEmpezar.gameObject.SetActive(true);
        buttonCalibrar.gameObject.SetActive(true);
    }

    public void irARegistro() {
        SceneManager.LoadScene("Experience");
    }

    public void Calibrar() {
        principalCanvas.gameObject.SetActive(false);
        calibrarCanvas.gameObject.SetActive(true);
        enCalibrar = true;
    }

    public void salirCalibrar() {
        principalCanvas.gameObject.SetActive(true);
        calibrarCanvas.gameObject.SetActive(false);
        enCalibrar = false;
    }

    public void CentrarCabrilla() {
        serial.centro = serial.simulador.Cabrilla;
    }
    private void Update()
    {
        if (enCalibrar) {
            togglePito.isOn = serial.simulador.Pito;
            toggleClutch.isOn = serial.simulador.Clutch;
            toggleFrenoMano.isOn = serial.simulador.FrenoMano;
            toggleFrenoPie.isOn = serial.simulador.FrenoPie;
            toggleDirDerecha.isOn = serial.simulador.DirDerecha;
            toggleDirIzquierda.isOn = serial.simulador.DirIzquierda;
            textCambio.text = serial.simulador.Cambio.ToString();
            textLuces.text = serial.simulador.Luces.ToString();
            textAcelerador.text = serial.simulador.Acelerador.ToString();
            textCabrilla.text = serial.simulador.Cabrilla.ToString();
            
        }
    }
}
