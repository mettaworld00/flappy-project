using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnearTubos : MonoBehaviour
{
    public float tiempoMax = 1;
    public float tiempo = 0;
    public GameObject tubos;
    public float altura;
    public float distanciaX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempo > tiempoMax) {
            GameObject nuevoTubo = Instantiate(tubos);
            nuevoTubo.transform.position = transform.position + new Vector3(distanciaX, Random.Range(-altura,altura),0);
            Destroy(nuevoTubo, 15);

            tiempo = 0;
        }
        tiempo += Time.deltaTime;
    }
}
