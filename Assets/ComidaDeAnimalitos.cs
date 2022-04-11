using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaDeAnimalitos : MonoBehaviour
{
    // Start is called before the first frame update

    //Realizar el programa que permita ingresar por inspector el código de la categoría del animal y cuántos días va a quedarse.

    public string codigo;
    public int dias;
    int gramos;
    int valor;
    void Start()
    {
       
        if (dias < 3)
        {
            Debug.Log("Error");
        }
        else if(codigo == "G")
        {
            gramos = dias * 300;
            valor = gramos / 100;
            valor *= 80;
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de la cantidad de alimento calculada es de: $" + valor);
        }
        else if(codigo == "PP")
        {
            gramos = dias * 400;
            valor = gramos / 100;
            valor *= 80;
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de la cantidad de alimento calculada es de: $" + valor);
        }
        else if (codigo == "PG")
        {
            gramos = dias * 700;
            valor = gramos / 100;
            valor *= 80;
            Debug.Log("Para ese período se necesitan " + gramos + " gramos de alimento");
            Debug.Log("El costo de la cantidad de alimento calculada es de: $" + valor);
        }
        else
        {
            Debug.Log("Error");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
