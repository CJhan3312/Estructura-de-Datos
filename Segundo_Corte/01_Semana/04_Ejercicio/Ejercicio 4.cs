using System;

namespace SumaMediaArrayApp
{
public class SumaMediaArrayApp 
{
 
    public static void main(String[] args) {
         
        int[] numeros=new int[100];
         
        int suma=0;
        double media;
         
        for(int i=0;i<numeros.length;i++){
            numeros[i]=i+1;
            suma+=numeros[i];
        }
         
        Console.WriteLine("La suma es "+suma);
         
        media=(double)suma/numeros.length;
         
        Console.WriteLine("La media es "+media);
         
    }
     
}
}