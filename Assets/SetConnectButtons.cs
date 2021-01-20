using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetConnectButtons : MonoBehaviour
{
    [SerializeField]
    Button conectar;

    [SerializeField]
    Button desconectar;

    Serial serial;

    // Start is called before the first frame update
    void Start()
    {
        serial = FindObjectOfType<Serial>();
        conectar.onClick.AddListener(serial.RefreshPorts);
        desconectar.onClick.AddListener(serial.CloseActualPort);
    }

   
}
