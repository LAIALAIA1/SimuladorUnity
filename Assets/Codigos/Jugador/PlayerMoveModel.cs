using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMoveModel : MonoBehaviour
{
    [SerializeField]
    private float speed, maxspeed = 100f, rot = 5f;
    
    [SerializeField]
    private PlayerMovePresenter presenter;

    [SerializeField]
    SoundsMobile soundsMobile;

    [SerializeField]
    AudioSource audio;

    [SerializeField]
    Animator motoAnim;

    [SerializeField]
    Transform SpawnPoint;

    [SerializeField]
    GameObject seCayoMoto;

    Experience experience;

    private bool rightDirectional;
    private bool leftDirectional;
    private bool cornet;

    private bool seCayo;

    public bool RightDirectional { get { return leftDirectional; } set { leftDirectional = value; } }
    public bool LeftDirectional { get { return rightDirectional; } set { rightDirectional = value;  } }
    bool frenar;

    private void Start()
    {
        speed = 0f;
        frenar = false;
        seCayo = false;
        seCayoMoto.SetActive(false);
        experience = GetComponent<Experience>();
    }

    public void MovePlayer(Vector2 joestick) {

        if (seCayo || experience.finish)
            joestick = new Vector2(0, 0);

        speed = presenter.EvalueVelocity(joestick.y,speed,frenar);

        motoAnim.SetFloat("rot", joestick.x);
        

        if (joestick.x != 0f) 
        {
            transform.Rotate(Vector3.up * rot * joestick.x * Time.deltaTime);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime );
        audio.pitch = (speed * 3 / maxspeed) + 0.5f;
        if (transform.localRotation.eulerAngles.z > 65f && transform.localRotation.eulerAngles.z < 90f || transform.localRotation.eulerAngles.z > 270f && transform.localRotation.eulerAngles.z < 295f) 
        {
            frenar = true;
            if (!seCayo)
            {
                frenar = true;
                seCayo = true;
                StartCoroutine(respawnPoint());
            }
        }
        if (frenar || experience.finish)
        {
            speed -= 1f;
            speed = Mathf.Clamp(speed, 0, maxspeed);
        }

        if (transform.localRotation.eulerAngles.z > 90f && transform.localRotation.eulerAngles.z < 270f) {
            speed -= 1.5f;
            speed = Mathf.Clamp(speed, 0, maxspeed);
        }
    }

    public void Frenar(bool breake) {
        if(!seCayo)
            frenar = breake;
    }

    public void Cornet(bool value) {
        if (value != cornet)
        {
            cornet = value;
            if (cornet) soundsMobile.Cornet();
            else soundsMobile.CornetStop();
        }

    }

    public void irAInicio() { SceneManager.LoadScene("inicio"); }

    public void RepetirExperiencia() { SceneManager.LoadScene("Experience"); }

    IEnumerator respawnPoint() {
        seCayoMoto.SetActive(true);
        yield return new WaitForSeconds(2f);
        transform.position = SpawnPoint.position;
        transform.rotation = SpawnPoint.rotation;
        speed = 0f;
        frenar = false;
        yield return new WaitForSeconds(2f);
        seCayo = false;
        seCayoMoto.SetActive(false);
    }
}
