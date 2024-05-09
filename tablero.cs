namespace Proyecto_2;

public class Tablero
{

    public string[,] ltablero = new string[8,8];

    public Tablero(string[,] ubicaciones){
        this.ltablero = ubicaciones;
    }

    public void evaluarPosicionesRectas(){
        int pos1 =0;
        int pos2 =0;
        
        for(int i = 0; i < ltablero.GetLength(0); i++){
            for(int j = 0; j < ltablero.GetLength(1); j++){// Recorre la matriz
            pos1=i;
            pos2=j;
            if(ltablero[i, j].Contains("dama blanco")){ //CASO DAMA BLANCA
                for(int k=0; k<(ltablero.GetLength(0)-i);k++){
                     
                        //if(!ltablero[pos1,pos2].Contains("blanco")){
                        Console.WriteLine("Las posiciones son: " +ltablero[pos1,pos2]);
                       // }
                       Console.WriteLine(ltablero.GetLength(0)-i);
                        pos2++;
                }

// FIN DE DAMA BLANCA

/*
            } else if(ltablero[i, j].Contains("dama negro")){ //CASO DAMA NEGRA
                  while(ltablero[pos1,pos2].Contains("blanco")){
                for(int k=0; k<(ltablero.GetLength(0)-i);k++){
                        Console.WriteLine("Las posiciones son: " +ltablero[pos1,pos2]);
                        pos2++;
                }
                }*/}

            } // FIN DE DAMA NEGRA


            }

            }
        
    
    
    public void graficarTablero(){
         for(int i = 0; i < ltablero.GetLength(0); i++){
         for(int z=0;  z< ltablero.GetLength(1); z++) {
            Console.Write("   " + ltablero[z,i]);
        }
        Console.WriteLine(" ");
        }
    
    }}

