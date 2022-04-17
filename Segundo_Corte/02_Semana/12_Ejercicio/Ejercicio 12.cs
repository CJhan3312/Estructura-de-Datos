using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;

namespace Matriz
{
public class Matriz 
{
 public static void main(String[] args) {
 
 $ matriz Original = matriz ( matriz ());
            $ matrizRotada = matriz ( matriz ());
            
            echo  "<div>" ;
            
            //relleno y muestro la matriz original
            echo  "<id de tabla='izq'>" ;
            echo  "<caption>Matriz Original</caption>" ;
            for ( $ fila = 0 ; $ fila < 12 ; $ fila ++) {
              eco  "<tr>" ;
              for ( $ columna = 0 ; $ columna < 12 ; $ columna ++) {
                $ matriz Original [ $ fila ][ $ columna ] = rand ( 0 , 100 );
                echo  "<td>" . $ matrizOriginal [ $ fila ][ $ columna ]. "</td>" ;
              }
              eco  "</tr>" ;
            }
            echo  "</tabla>" ;
            
            //roto la matriz original y la guardia en la rotada
            $ columnaR = 11 ;
            for ( $ fila = 0 ; $ fila < 12 ; $ fila ++) {
              $ filaR = 0 ;
              for ( $ columna = 0 ; $ columna < 12 ; $ columna ++) {
                $ matrizRotada [ $ filaR ][ $ columnaR ] = $ matrizOriginal [ $ fila ][ $ columna ];
                $ filaR ++;
              }
              $ columnaR --;
            }
            
            //muestro la matriz final rotada
            echo  "<table id='der'>" ;
            echo  "<caption>Matriz Rotada</caption>" ;
            for ( $ fila = 0 ; $ fila < 12 ; $ fila ++) {
              eco  "<tr>" ;
              for ( $ columna = 0 ; $ columna < 12 ; $ columna ++) {
                echo  "<td>" . $ matrizRotada [ $ fila ][ $ columna ]. "</td>" ;
              }
              eco  "</tr>" ;
            }
            echo  "</tabla>" ;
                }
}
}