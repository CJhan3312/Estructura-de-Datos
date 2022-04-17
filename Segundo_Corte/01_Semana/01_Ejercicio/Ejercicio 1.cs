using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;

namespace arrayApp
{
public class arrayApp {
 
    public static void main(String[] args) {
 
        //Esto es opcional
        final int TAMANIO=10;
 
        int num[]=new int[TAMANIO];
 
        //Invocamos las funciones
        rellenarArray(num);
 
        mostrarArray(num);
    }
 
    public static void rellenarArray(int lista[]){
        for(int i=0;i<lista.length;i++){
            String texto=Console.WriteLine("Introduce un número");
            lista[i]=Integer.parseInt(texto);
        }
    }
 
    public static void mostrarArray(int lista[]){
        for(int i=0;i<lista.length;i++){
           Console.WriteLine("En el indice "+i+" esta el valor "+lista[i]);
        }
    }
}
}