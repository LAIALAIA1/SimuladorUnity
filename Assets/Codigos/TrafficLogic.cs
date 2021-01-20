using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HutongGames.PlayMaker;
public class TrafficLogic : MonoBehaviour
{
    [SerializeField]
    private PlayMakerFSM fsmCarros;

    [SerializeField]
    private PlayMakerFSM fsmTranseuntes;

    [SerializeField]
    private int NoCarros;

    [SerializeField]
    private int NoTranseuntes;
    float time;
    FsmBool ped;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        FsmBool carros = fsmCarros.FsmVariables.GetFsmBool("addCar");
        carros.Value = true;
        ped = fsmTranseuntes.FsmVariables.GetFsmBool("addPed");
        ped.Value = true;
        StartCoroutine(CrearCarros(carros));
        StartCoroutine(CrearTranseuntes(ped));

    }

    private IEnumerator CrearCarros(FsmBool crear) {
        yield return new WaitWhile(()=> (GameObject.FindGameObjectsWithTag("Car").Length< NoCarros));
        crear.Value = false;
    }

    private IEnumerator CrearTranseuntes(FsmBool crear)
    {
        yield return new WaitWhile(() => (GameObject.FindGameObjectsWithTag("Ped").Length < NoTranseuntes));
        crear.Value = false;
    }

    

  
}
