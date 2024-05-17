namespace Proyecto_2; 
 class Program
{
    public static void Main(string[] args)
    {
     string[,] ubicacionpieza = new string[8,8]; //matriz para almacenar la posicion de las piezas del tablero.
        int tipoPieza =0;  int numpieza =0;int k =0; int l=1;string ubicaciondama ="";
        
        //Declarar los espacios del arreglo como libres
        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                ubicacionpieza[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);
        }
        }


        Console.WriteLine("Cuantas piezas desea agregar?");
        numpieza = int.Parse(Console.ReadLine());
        string[] pieza = new string[numpieza]; 
        while (l <= numpieza){
            do{
        Console.WriteLine("Qué tipo de pieza desea agregar? \n 1) alfil blanco \n 2) peón blanco \n 3) caballo blanco\n 4) torre blanca \n 5) alfil negro \n 6) peón negro \n 7) caballo negro\n 8) torre negra");
        int.TryParse(Console.ReadLine(), out tipoPieza);

        if(tipoPieza>8){
            Console.WriteLine("El numero no está entre las opciones, intenta de nuevo");
        }
}while(tipoPieza>8);

        switch(tipoPieza){ 
            
            case 1: pieza[k] = "alfil blanco";break;
            case 2: pieza[k] = "peon blanco";break;
            case 3: pieza[k] = "caballo blanco";break;
            case 4: pieza[k] = "torre blanco";break;
            case 5: pieza[k] = "alfil negro";break;
            case 6: pieza[k] = "peon negro";break;
            case 7: pieza[k] = "caballo negro";break;
            case 8: pieza[k] = "torre negro";break;} // ASIGNAR LA PIEZA

    //ubicacion de la pieza
    bool validar = false;string ubicacion;string pos="";
    do{
        Console.WriteLine("En qué ubicación desea colocar la pieza?");
         ubicacion =Console.ReadLine();

        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicacionpieza[i,j]==ubicacion){
                 

                    if(pos == pieza[k]){
                    validar = true;
                    Console.WriteLine("Esa posicion ya está ocupada");
            } 
                }
                
        }
        }
    }while(validar == true);

        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicacion.Contains(Convert.ToChar(97+i)) && ubicacion.Contains(Convert.ToChar(49+j))){
            ubicacionpieza[0+i,j]= pieza[k];
            } 
        }
        }
        k++;l++;}

        int dm;
        do{
        Console.WriteLine("Desea que la dama sea: \n 1) blanca \n 2) negra");
         dm = int.Parse(Console.ReadLine());
          }while(dm!=1 && dm!=2);
        Console.WriteLine("En que espacio desea la dama? ");
        ubicaciondama = Console.ReadLine();
         for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicaciondama.Contains(Convert.ToChar(97+i)) && ubicaciondama.Contains(Convert.ToChar(49+j))){
               if(dm == 1){ 
            ubicacionpieza[0+i,j]= "dama blanca";
            }else if(dm ==2){
              ubicacionpieza[0+i,j]= "dama negra";

            }
            } 
        }
        }

       

        Tablero objtablero = new Tablero(ubicacionpieza, numpieza);
        objtablero.graficarTablero();
        objtablero.definirposiciones();
        objtablero.evaluarPosicionesRectas();
        objtablero.evaluarPosicioneshorizontales();
        objtablero.evaluarPosicionesdiagonales1();
        objtablero.evaluarPosicionesdiagonales2();
   
      




    }
}