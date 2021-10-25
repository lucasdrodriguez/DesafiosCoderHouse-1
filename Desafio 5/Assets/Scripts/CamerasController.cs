using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public GameObject[] cameras;
    public GameObject roof;
    public GameObject playerPosition;
    bool camaraAutomatica;
    //Vector3 personajeLimite = new Vector3(-0f, 1.8f - 12f);


    // Start is called before the first frame update
    void Start()
    {
        camaraAutomatica = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camaraAutomatica = !camaraAutomatica;
        }
        if (camaraAutomatica == false)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                cameras[0].SetActive(true);
                cameras[1].SetActive(false);
                cameras[2].SetActive(false);
                cameras[3].SetActive(false);
                roof.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);
                cameras[2].SetActive(false);
                cameras[3].SetActive(false);
                roof.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(false);
                cameras[2].SetActive(true);
                cameras[3].SetActive(false);
                roof.SetActive(false);
            }
            if (Input.GetKeyDown(KeyCode.F4))
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(false);
                cameras[2].SetActive(false);
                cameras[3].SetActive(true);
                roof.SetActive(true);
            }
        }
       
        //Camaras se activan con el movimiento del personaje
        if (camaraAutomatica == true)
        {
            if (playerPosition.transform.position.x > 0)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);
                cameras[2].SetActive(false);
                cameras[3].SetActive(false);
                roof.SetActive(true);
            }
            if (playerPosition.transform.position.x < 0)
            {
                cameras[0].SetActive(true);
                cameras[1].SetActive(false);
                cameras[2].SetActive(false);
                cameras[3].SetActive(false);
                roof.SetActive(true);
            }
            if (playerPosition.transform.position.z < -14)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(false);
                cameras[2].SetActive(true);
                cameras[3].SetActive(false);
                roof.SetActive(false);
            }
        }
        

    }
  

}