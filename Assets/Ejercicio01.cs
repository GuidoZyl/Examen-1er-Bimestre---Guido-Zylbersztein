using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public int cantidadDeUnidades, cantDias, cantDiasLluvia;
    int costoTotalCumbustible = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (cantDias < 5 || cantDiasLluvia > cantDias || cantDiasLluvia < 0)
        {
            Debug.Log("Ingrese valores válidos");
        }

        else
        {
            costoTotalCumbustible = cantidadDeUnidades * cantDias * 6 * 130;
            costoTotalCumbustible += cantidadDeUnidades * cantDiasLluvia * 2 * 130;

            Debug.Log("Una flota de " + cantidadDeUnidades + " unidades trabajando durante " + cantDias +
              " días implicará un gasto de " + costoTotalCumbustible + " pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
