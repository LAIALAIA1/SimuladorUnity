using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
public class Experience : MonoBehaviour
{
    [SerializeField]
    Text reloj;

    [SerializeField]
    Text faltasText;

    [SerializeField]
    Text CebraAdvertencia;

    [SerializeField]
    Image CebraRoja;

    [SerializeField]
    List<GameObject> BotoneFinal;

    [SerializeField]
    GameObject finExperiencia;

    [SerializeField]
    GameObject errorEnviarData;

    float seg;
    int min;
    public bool finish;

    public int faltas;

    //------------Datos viejos----------------
    [SerializeField]
    Rigidbody player;

    [SerializeField]
    ViewDatosPlayer datosPlayer;

    Serial movimiento_Moto;
    bool pare;
    bool cruce;

    // Contadores de faltas

    public int min30 = 0;//a,p,c
    public int max60 = 0;//a,p,c
    public int Pare = 0;//a,p,c
    public int CebraNo = 0;//a,p,c
    public int PeatonNo = 0;//a,p,c
    public int contraviaNo = 0;//a,p,c
    public int choqueVehiculoNo = 0;//a,p,c
    public int montarAnden = 0;//a,p,c
    public int lucesNo = 0;//
    public int prohibido_girar = 0;//a,p,c
    public int semaforo = 0;//a,p,c
    public int direccionales = 0;//a,p,c

    float cont_cebra;
    bool giro_prohibido;
    bool falta;
    bool x;
    float x_ant;
    float z_ant;
    float y_ant;

    float xVelAnt = 0f;
    float yVelAnt = 0f;
    float zVelAnt = 0f;
    float velX = 0f, velY = 0f, velZ = 0f;

    bool sendAPI;

    // Start is called before the first frame update
    void Start()
    {

        min = 0;
        seg = 0;
        finish =false;
        sendAPI = false;
        finExperiencia.SetActive(false);
        errorEnviarData.SetActive(false);
        foreach (GameObject bt in BotoneFinal)
            bt.SetActive(false);
        // ----- Viejos----------
        movimiento_Moto = FindObjectOfType<Serial>();
        cont_cebra = 0.0f;
        giro_prohibido = false;
        x_ant = player.worldCenterOfMass.x;
        z_ant = player.worldCenterOfMass.z;
        y_ant = player.worldCenterOfMass.y;
    }
    IEnumerator finishExp() {
        finExperiencia.SetActive(true);
        WWWForm form = new WWWForm();

        // Info Player
        form.AddField("tipo_vehiculo", datosPlayer.DropdownTipoVehiculo.options[datosPlayer.DropdownTipoVehiculo.value].text);
        form.AddField("nombres", datosPlayer.InputNombres.text);
        form.AddField("apellidos", datosPlayer.InputNombres.text);
        form.AddField("no_documento", datosPlayer.InputID.text);
        form.AddField("tipo_documento", datosPlayer.DropdownTipoDocu.options[datosPlayer.DropdownTipoDocu.value].text);
        form.AddField("correo", datosPlayer.InputCorreo.text);
        form.AddField("celular", datosPlayer.InputCelular.text);
        form.AddField("lugar", datosPlayer.InputLugar.text);

        // Multas data
        form.AddField("min_treinta_multa", min30);
        form.AddField("max_sesenta_multa", max60);
        form.AddField("pare_multa", Pare);
        form.AddField("cebra_multa", CebraNo);
        form.AddField("peaton_multa", PeatonNo);
        form.AddField("contravia_multa", contraviaNo);
        form.AddField("choque_vehiculo_multa", choqueVehiculoNo);
        form.AddField("montar_anden_multa", montarAnden);
        form.AddField("luces_multa", lucesNo);
        form.AddField("prohibido_girar", prohibido_girar);
        form.AddField("direccionales", direccionales);
        form.AddField("semaforos", semaforo);


        using (UnityWebRequest www = UnityWebRequest.Post("http://www.finstruvial.com/simulador/", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                //ERROR Falta crear ojo
                errorEnviarData.SetActive(true);
                errorEnviarData.GetComponent<Text>().text = "OCURRIO UN ERROR AL ENVIAR LOS DATOS, RECUERDE LOS CORREOS CON @, CELULAR E IDENTIFICACIÓN SOLO NÚMEROS. error:  "+ www.error;
                foreach (GameObject bt in BotoneFinal)
                    bt.SetActive(true);
            }
            else
            {
                foreach (GameObject bt in BotoneFinal)
                    bt.SetActive(true);
                Debug.Log("Form upload complete!");
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!finish)
        {
            seg += Time.deltaTime;
            if (seg > 60)
            {
                min += 1;
                seg = 0;
            }
            reloj.text = min.ToString() + ":" + ((int)seg).ToString() ;
            if (min >= 2 || faltas >= 20 && !finish) {
                finish = true;
                StartCoroutine(finishExp());
            }
            faltasText.text = faltas.ToString();
        }

        if (falta)
        {
            cont_cebra += Time.deltaTime;
            if (cont_cebra >= 5f)
            {
                CebraRoja.enabled = false;
                CebraAdvertencia.enabled = false;
                falta = false;
                giro_prohibido = false;
                cont_cebra = 0f;
            }
        }
        velX = (player.worldCenterOfMass.x - x_ant)/Time.deltaTime;
        velY = (player.worldCenterOfMass.y - y_ant) / Time.deltaTime;
        velZ = (player.worldCenterOfMass.z - z_ant) / Time.deltaTime;
        Debug.Log("x:" + velX + "    y: " + velY + "    z:" + velZ);
        movimiento_Moto = FindObjectOfType<Serial>();
        if (!finish)
            if (Mathf.Abs((int)velX) > 0.001f || Mathf.Abs((int)velZ) > 0.001f)
        {
            if (Mathf.Abs(velX) > Mathf.Abs(velZ))
            {
                if (x == false && movimiento_Moto != null)
                {
                    //Preguntar si la direccional esta encendida
                    if (xVelAnt > 0f)
                    {
                        if (velZ < 0f)
                        {
                            if (!movimiento_Moto.DirIzquierda)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }
                        else
                        {
                            if (movimiento_Moto.DirDerecha)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }
                    }

                    else
                    {
                        if (velZ < 0f)
                        {
                            if (!movimiento_Moto.DirDerecha)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }
                        else
                        {
                            if (!movimiento_Moto.DirIzquierda)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }
                    }
                    x = true;
                }
            }
            else
            {
                if (x == true)
                {
                    // Preguntar si la dirreccional esta encendida
                    if (zVelAnt > 0)
                    {
                        if (velX < 0f)
                        {
                            if (movimiento_Moto.DirDerecha == false)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }
                        else
                        {
                            if (movimiento_Moto.DirIzquierda == false)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }

                        }

                    }
                    else
                    {
                        if (velX < 0f)
                        {
                            if (movimiento_Moto.DirIzquierda == false)
                            {
                                Falta("No Direccional");                                
                                direccionales += 1;
                            }

                        }
                        else
                        {
                            if (movimiento_Moto.DirDerecha == false)
                            {
                                Falta("No Direccional");
                                direccionales += 1;
                            }
                        }
                    }

                    x = false;
                }


            }
        }

        x_ant = player.worldCenterOfMass.x;
        z_ant = player.worldCenterOfMass.z;
        y_ant = player.worldCenterOfMass.y;

        xVelAnt = velX;
        zVelAnt = velZ;
        yVelAnt = velY;

    }
    public void Falta(string nombreFalta) {
        if (!finish)
        {
            faltas += 1;
            falta = true;
            CebraAdvertencia.enabled = true;
            CebraRoja.enabled = true;
            CebraAdvertencia.text = nombreFalta;
        }
    }
    private void OnCollisionEnter(Collision otro)
    {
        if (!finish)
        {
            if (otro.gameObject.tag == "Ped")
            {
                Falta("Peaton");
                PeatonNo += 1;
            }
            if (otro.gameObject.tag == "Anden")
            {
                Falta("Choco anden");
                montarAnden += 1;

            }

            if (otro.gameObject.tag == "Car")
            {
                Falta("Choco Vehículo");
                choqueVehiculoNo += 1;
            }
        }
        
    }
    void OnTriggerEnter (Collider otro)
    {

        if (!finish)
        {
            if (otro.gameObject.tag == "min30")
            {
                if (Mathf.Abs(velX) < 30f || Mathf.Abs(velZ) < 30f)
                {
                    Falta("Debajo del Minimo");
                    min30 += 1;
                }

            }

            if (otro.gameObject.tag == "max60")
            {
                if (Mathf.Abs(velX) > 60f || Mathf.Abs(velZ) > 60f)
                {
                    Falta("Velocidad Maxima");
                    max60 += 1;
                }

            }



            if (otro.gameObject.tag == "no_dere")
            {

                giro_prohibido = true;
            }

            if (otro.gameObject.tag == "omitio_no_dere" && giro_prohibido == true)
            {

                Falta("Giro Prohibido");
                giro_prohibido = false;
                prohibido_girar += 1;
            }

            if (otro.gameObject.tag == "salio_bien")
            {
                giro_prohibido = false;

            }
            //Check to see if the Collider's name is "Chest"
            if (otro.gameObject.tag == "dirXPosi")
            {
                if (velX < -0.001f)
                {
                    Falta("Contravia");
                    contraviaNo += 1;
                }
            }

            if (otro.gameObject.tag == "dirXnega")
            {
                if (velX > 0.001f)
                {
                    Falta("Contravia");
                    contraviaNo += 1;
                }
            }

            if (otro.gameObject.tag == "dirZposi")
            {
                if (velZ < -0.001f)
                {
                    Falta("Contravia");
                    contraviaNo += 1;
                }
            }

            if (otro.gameObject.tag == "dirZnega")
            {
                if (velZ > 0.001f)
                {
                    Falta("Contravia");
                    contraviaNo += 1;
                }
            }

            if (otro.gameObject.tag == "semaforo")
            {
                Falta("Semaforo Rojo");
                contraviaNo += 1;
            }

            if (otro.gameObject.tag == "Pare")
            {
                pare = false;
            }

            if (otro.gameObject.tag == "cruce_peatonal")
            {
                cruce = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!finish)
        {
            if (other.gameObject.tag == "Pare")
            {
                if (player.velocity.x == 0 && player.velocity.z == 0)
                {
                    pare = true;
                }
            }
            if (other.gameObject.tag == "cruce_peatonal")
            {
                if (velX == 0 && velZ == 0)
                {
                    cruce = true;
                }
            }
        }
    }

    private void OnCollisionStay(Collision other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (!finish)
        {
            if (other.gameObject.tag == "Pare")
            {
                if (pare == false)
                {
                    Falta("No hizo pare");
                    Pare += 1;
                }
            }

            if (other.gameObject.tag == "cruce_peatonal")
            {
                if (cruce == false)
                {
                    Falta("Cruce Peatonal");
                    CebraNo += 1;
                }
            }
        }

    }

    private void OnCollisionExit(Collision other)
    {
        
    }
}
