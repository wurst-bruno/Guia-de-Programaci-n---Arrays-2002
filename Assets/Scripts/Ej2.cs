using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    [SerializeField] string[] nombremeses = new string[12];
    [SerializeField] int[] diasmensuales = new int[12];
    public string fechaIngresada;

    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
    }
    

    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;


        if (fecha.Length == 4)
        {
            string dia = ""; // agrega al final de la cadena 0
            string mes = "";
            dia += fecha[0];
            dia += fecha[1];
            int dianumber = int.Parse(dia); //lo pasa a int
            mes += fecha[2];
            mes += fecha[3];
            int mesnumber = int.Parse(mes);
            if (dianumber > 0 && dianumber <=31 && mesnumber>0 && mesnumber <=12)
            {
                fechaValida = true;
            }
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto");
        }

        return fechaValida;
    }


}
