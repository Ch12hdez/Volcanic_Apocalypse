using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public float vida;
    public GameObject[] vidas;
    public Slider barraVida;
    // Start is called before the first frame update
    void Start()
    {
        barraVida.value = vida;
        //vidas = new GameObject[(int)vida];
        //vidas = GameObject.FindGameObjectsWithTag("MarcadorVida");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vida--;
            vidas[(int)vida].SetActive(false);
            barraVida.value = vida;
        }
    }
}
