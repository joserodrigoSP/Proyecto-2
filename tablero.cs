namespace Proyecto_2;

public class Tablero
{

    public string[,] ltablero = new string[8,8];

    public Tablero(string[,] ubicaciones){
        this.ltablero = ubicaciones;
    }

    public void evaluarPosiciones(){
        for(int i = 0; i < ltablero.GetLength(0); i++){
            for(int j = 0; j < ltablero.GetLength(1); j++){
                if(ltablero[i,j] == "dama"){
                    if(ltablero[i, j+1].Contains("negro")){
                        Console.WriteLine("");
                    }

                }


            }
        }
    }

    public void graficarTablero(){
         for(int i = 0; i < ltablero.GetLength(0); i++){
         for(int z=0;  z< ltablero.GetLength(1); z++) {
            Console.Write(" " + ltablero[z,i]);
        }
        Console.WriteLine(" ");
        }
    }
    
}
