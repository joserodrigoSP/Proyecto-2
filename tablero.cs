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
            int k=0; 
            if(ltablero[i, j].Contains("dama blanca")){ //CASO DAMA BLANCA
           
             while(!(ltablero[pos1,pos2].Contains("blanco")||ltablero[pos1,pos2].Contains("negro")) && k<(ltablero.GetLength(0)-i)){
                
                
                        //if(!ltablero[pos1,pos2].Contains("blanco")){
                        Console.WriteLine("Las posiciones son: " +ltablero[pos1,pos2]);
                       // }
                       Console.WriteLine(ltablero.GetLength(0)-i);
                       Console.WriteLine(k);
                        pos2++;
                        k++;

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

