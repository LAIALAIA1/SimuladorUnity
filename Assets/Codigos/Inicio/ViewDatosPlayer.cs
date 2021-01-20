using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ViewDatosPlayer : MonoBehaviour {

    public InputField InputNombres ;
    public InputField InputID;
    public InputField InputCorreo;
    public InputField InputCelular;
    public InputField InputLugar;
    public Dropdown DropdownTipoDocu;
    public Dropdown DropdownDia;
    public Dropdown DropdownTipoVehiculo;

    [SerializeField]
    List<GameObject> PlayerSets;

    [SerializeField]
    GameObject CanvasRegister;

   
	
    public void EmpezarBoton(){
        if (InputNombres != null  && InputID != null && InputCorreo != null && InputLugar != null)
        {
            foreach (GameObject ob in PlayerSets) 
                ob.SetActive(true);
            CanvasRegister.SetActive(false);
            
        }
    }
}
