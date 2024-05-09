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
            int valores =0;
            if(ltablero[i, j].Contains("dama blanca")){ //---------------------------------------CASO DAMA BLANCA
            valores =ltablero.GetLength(0)-j;
            /// if para saber si el valor es positivo o es negativo
             while(!(ltablero[pos1,pos2].Contains("blanco")||ltablero[pos1,pos2].Contains("negro")) && k<valores){
                
                if(j<valores){
                        Console.WriteLine("Las posiciones son: " +ltablero[pos1,pos2]);
                        Console.WriteLine(valores);
                        Console.WriteLine("Valor de i: " +i+ "valor de j: "+j);
                        Console.WriteLine("Valor de tablero: " +ltablero.GetLength(0));
                        pos2++;
                        k++;
                        }else{
                            Console.WriteLine("Las posiciones son: " +ltablero[pos1,pos2]);
                        Console.WriteLine(valores);
                        Console.WriteLine("Valor de i: " +i+ "valor de j: "+j);
                        Console.WriteLine("Valor de tablero: " +ltablero.GetLength(0));
                        pos2--;
                        k++;
                        }

                }

// ---------------------------------FIN DE DAMA BLANCA-------------------- NO TOCAR ---------------------

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

