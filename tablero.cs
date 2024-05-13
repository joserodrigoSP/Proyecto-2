namespace Proyecto_2;

public class Tablero
{

    public string[,] ltablero = new string[8,8];

    public Tablero(string[,] ubicaciones){
        this.ltablero = ubicaciones;
    }

    public void evaluarPosicionesRectasPzsBlancas(){ /// EVALUA POSICIONES BLANCAS 
        int pos1 =0;
        int pos2 =0;
        int pos3=0;
        for(int i = 0; i < ltablero.GetLength(0); i++){
            for(int j = 0; j < ltablero.GetLength(1); j++){// Recorre la matriz
            pos1=i;
            pos2=j+1;
            pos3=j-1;
            int k=0; 
            int m =0;
            int valores =0;
            int valor =0;
            if(ltablero[i, j].Contains("dama blanca")){ //---------------------------------------CASO DAMA BLANCA
            valores =ltablero.GetLength(0)-j;
             valor = 8 -valores;
 /// APARTADO SI --- ---  EN CASO LA PIEZA-------------------- --------- ------- ------- ----- ES BLANCA EVALUAR POSICIONES RECTAS
           
  /// --------------------- FIN DEL - -- -- -- --- --- --APARTADO -- --  SI --  EN ----CASO LA PIEZA ES BLANCA EVALUAR POSICIONES RECTAS

             while(!(ltablero[pos1,pos3].Contains("blanco")||ltablero[pos1,pos3].Contains("negro")) && m<valor){
                
                        Console.WriteLine("--- Las posiciones son: " +ltablero[pos1,pos3]);
                        pos3--;
                        m++;
             } 
                if(ltablero[pos1,pos3].Contains("negro")){
                Console.WriteLine("--- Las posiciones son: " +ltablero[pos1,pos3]);
             }
            /// APARTADO SI EN CASO LA PIEZA ES BLANCA EVALUAR POSICIONES RECTAS
             while(!(ltablero[pos1,pos2].Contains("blanco")||ltablero[pos1,pos2].Contains("negro")) && k<valores){
                
                        Console.WriteLine("--- Las posiciones son: " +ltablero[pos1,pos2]);
                        pos2++;
                        k++;
            
                        
         
             } 
             if(ltablero[pos1,pos2].Contains("negro")){
                Console.WriteLine("--- Las posiciones son: " +ltablero[pos1,pos2]);
             }/// FIN DEL APARTADO SI EN CASO LA PIEZA ES BLANCA EVALUAR POSICIONES RECTAS


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
    
    }}

