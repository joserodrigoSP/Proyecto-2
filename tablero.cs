﻿namespace Proyecto_2;

public class Tablero
{
   public int validar;
    public string[,] ltablero = new string[8,8];
   public string[,] posiciones = new string[8,8];
    public Tablero(string[,] ubicaciones, int val){
        this.ltablero = ubicaciones;
        this.validar = val;
    }
    public void definirposiciones(){
      for(int i=0; i<posiciones.GetLength(0); i++){
            for(int j=0; j<posiciones.GetLength(1); j++){
                posiciones[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);
        }
        }
    }

    public void evaluarPosicionesRectas(){ /// EVALUA POSICIONES BLANCAS 
    int k =0;
    int p =0;
    int q = 0;
        int pos1=0;
        int pos2=0;
        int pos3=0;
        int pos4=0;
        int pos5=0;
        int valor =0;
        int vap =0;
        for(int i = 0; i < ltablero.GetLength(0); i++){
            for(int j = 0; j < ltablero.GetLength(1); j++){// Recorre la matriz
            if(ltablero[i,j].Contains("dama blanca")){
               pos1=i;
               pos2=j;
               pos3=j;
               valor = 7-j;
               vap = 8-valor;
                  if(this.validar==0){
                     for(int m=0; m<=valor; m++){
                        if(!(ltablero[i,j+m].Contains("blanco") || ltablero[i,j+m].Contains("negro"))){
                           Console.WriteLine("la pasicion es: "+ ltablero[i,j+m]);

                        }
                     }
                     q=j;
                   while(!(ltablero[i,q].Contains("blanco") || ltablero[i,q].Contains("negro")) && q>=1){
                     Console.WriteLine("la pasicion es: "+ ltablero[i,q-1]);
                     q--;
                   }



                  }else{
                  while(!(ltablero[i,pos2].Contains("blanco") || ltablero[i,pos2].Contains("negro"))  && k<valor && pos2<7){
                  Console.WriteLine("la posicion es: "+ ltablero[i,pos2+1]);
                  pos2++;k++;
                  }
                  if(ltablero[i,pos2].Contains("negro")){
                     Console.WriteLine("la posicion es: "+ posiciones[i,pos2]);
                  }


                   while(!(ltablero[i,pos3].Contains("blanco") || ltablero[i,pos3].Contains("negro")) && p<=vap &&pos3>0){
                  Console.WriteLine("la posicion es: "+ ltablero[i,pos3-1]);
                  pos3--;p++;
                  }
                  if(ltablero[i,pos3].Contains("negro")){
                     Console.WriteLine("la posicion es: "+ posiciones[i,pos3]);
                  }
                  }



            } 
      
            }
            }
            }


    
    
    public void graficarTablero(){
         for(int i = 0; i < ltablero.GetLength(0); i++){
         for(int z=0;  z< ltablero.GetLength(1); z++) {
            Console.Write("   " + ltablero[z,i]);
        }
        Console.WriteLine(" ");
        }
    
    }
    
    
    
    public void graficarPosiciones(){
         for(int i = 0; i < posiciones.GetLength(0); i++){
         for(int z=0;  z< posiciones.GetLength(1); z++) {
            Console.Write("   " + posiciones[z,i]);
        }
        Console.WriteLine(" ");
        }
    
    }
    
    }

