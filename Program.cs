﻿ class Program
{
    public static void Main(string[] args)
    {

     bool[,] ubicacionpieza = new bool[8,8]; //matriz para almacenar la posicion de las piezas del tablero.
        int tipoPieza =0; int opcion=0; int numpieza =0;int k =0; int l=1;
        
        
        Console.WriteLine("Cuantas piezas desea agregar?");
        int.TryParse(Console.ReadLine(), out numpieza);
        string[] pieza = new string[numpieza]; 
        do{
        Console.WriteLine("Qué tipo de pieza desea agregar? \n 1) alfil blanco \n 2) peón blanco \n 3) caballo blanco\n 4) torre blanca \n 5) alfil negro \n 6) peón negro \n 7) caballo negro\n 8) torre negra");
        int.TryParse(Console.ReadLine(), out tipoPieza);
        switch(tipoPieza){ 
            
            case 1: pieza[k] = "alfil blanco";break;
            case 2: pieza[k] = "peon blanco";break;
            case 3: pieza[k] = "caballo blanco";break;
            case 4: pieza[k] = "torre blanca";break;
            case 5: pieza[k] = "alfil negro";break;
            case 6: pieza[k] = "peon negro";break;
            case 7: pieza[k] = "caballo negro";break;
            case 8: pieza[k] = "torre negra";break;} // ASIGNAR LA PIEZA

    //ubicacion de la pieza
        Console.WriteLine("En qué ubicación desea colocar la pieza?");
        string ubicacion =Console.ReadLine();

       
        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicacion.Contains(Convert.ToChar(97+i)) && ubicacion.Contains(Convert.ToChar(49+j))){
            ubicacionpieza[0+i,j]= true;
            } 
        }
        }
        Console.WriteLine("El numero de pieza es: "+ numpieza+ ". Y el numero l es: "+ l);
        k++;l++;}while (l <= numpieza);

        

        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                Console.WriteLine("-"+ ubicacionpieza[j,i]);
            } 
        }


        for(int i=0; i<pieza.Length; i++){
           Console.WriteLine(pieza[i]);
        }
      




    }
}