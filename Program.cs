namespace Proyecto_2; 
 class Program
{
    public static void Main(string[] args)
    {
     string[,] ubicacionpieza = new string[8,8];string[,] nuevotablero = new string[8,8]; string[,] otrotablero = new string[8,8];
      //matriz para almacenar la posicion de las piezas del tablero.
        int tipoPieza =0;  int numpieza =0;int k =0; int l=1;string ubicaciondama ="";
        
        //Declarar los espacios del arreglo como libres
        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                ubicacionpieza[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);
        }
        }
        //Declarar los espacios del arreglo como libres
        for(int i=0; i<otrotablero.GetLength(0); i++){
            for(int j=0; j<otrotablero.GetLength(1); j++){
                otrotablero[i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);
        }
        }
          //Declarar los espacios del arreglo 2 como libres
        for(int i=0; i<nuevotablero.GetLength(0); i++){
            for(int j=0; j<nuevotablero.GetLength(1); j++){
                nuevotablero[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);
        }
        }


        Console.WriteLine("Cuantas piezas desea agregar?"); //pidiendole al usuario las piezas
        numpieza = int.Parse(Console.ReadLine());
        string[] pieza = new string[numpieza]; //se crea una matriz dependiendo de las piezas que desee el usuario
        while (l <= numpieza){
            do{
        Console.WriteLine("Qué tipo de pieza desea agregar? \n 1) alfil blanco \n 2) peón blanco \n 3) caballo blanco\n 4) torre blanca \n 5) alfil negro \n 6) peón negro \n 7) caballo negro\n 8) torre negra");
        int.TryParse(Console.ReadLine(), out tipoPieza);

        if(tipoPieza>8){ // pide las piezas y no deja que sea mayor a 8
            Console.WriteLine("El numero no está entre las opciones, intenta de nuevo");
        }
}while(tipoPieza>8);

        switch(tipoPieza){ 
            
            case 1: pieza[k] = "alfil blanco";break;
            case 2: pieza[k] = "peon blanco";break; //define a pieza segun el espacio que corresponda
            case 3: pieza[k] = "caballo blanco";break;
            case 4: pieza[k] = "torre blanco";break;
            case 5: pieza[k] = "alfil negro";break;
            case 6: pieza[k] = "peon negro";break;
            case 7: pieza[k] = "caballo negro";break;
            case 8: pieza[k] = "torre negro";break;} // ASIGNAR LA PIEZA

    //ubicacion de la pieza
    bool validar = false;string ubicacion;string pos="";  // se declara una variable bool para validar la pieza
    do{
        Console.WriteLine("En qué ubicación desea colocar la pieza?");
         ubicacion =Console.ReadLine();


         for(int i=0; i<nuevotablero.GetLength(0); i++){
            for(int j=0; j<nuevotablero.GetLength(1); j++){
                if(ubicacion.Contains(Convert.ToChar(97+i)) && ubicacion.Contains(Convert.ToChar(49+j))){
            nuevotablero[i,j]= pieza[k];
            } 
        }
        }


   for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(otrotablero[i,j].Contains(ubicacion)){
                 int pos1 =i;
                 int pos2 =j;
                validar = false; // SI NO ESTÁ OCUPADA PR DEFECTO SERÁ FALSE
                        for(int f =0; f<pieza.Length; f++){
                                 if(ubicacionpieza[pos1, pos2] == pieza[f]){  //RECORRE TODAS LAS POSIBLES PIEZAS Y NOS DICE SI ESTÁ OCUPADA
                    validar = true;
                    Console.WriteLine("Esa posicion ya está ocupada");
                     }
                        }

                   
                }
        }
        } }while(validar == true);
   

        for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicacion.Contains(Convert.ToChar(97+i)) && ubicacion.Contains(Convert.ToChar(49+j))){
            ubicacionpieza[i,j]= pieza[k];
            } 
        }
        }   // PONE EN LA UBICACION QUE DESEO EL USUARIO LA PIEZA QUE ELIGIO
                 

        k++;l++;} // INCREMENTA PARA HACER VÁLIDA LA EXPRESION

        int dm;
        do{
        Console.WriteLine("Desea que la dama sea: \n 1) blanca \n 2) negra");
         dm = int.Parse(Console.ReadLine());
         if(dm==1 && dm==2){
            Console.WriteLine("Esa opción no es válida \n");
         }
          }while(dm!=1 && dm!=2);
        
        Console.WriteLine("En que espacio desea la dama? ");
        ubicaciondama = Console.ReadLine();
         for(int i=0; i<ubicacionpieza.GetLength(0); i++){
            for(int j=0; j<ubicacionpieza.GetLength(1); j++){
                if(ubicaciondama.Contains(Convert.ToChar(97+i)) && ubicaciondama.Contains(Convert.ToChar(49+j))){
               if(dm == 1){ 
            ubicacionpieza[0+i,j]= "dama blanca";
            }else if(dm ==2){
              ubicacionpieza[0+i,j]= "dama negra"; // DEFINE LA POSICION DE LA DAMA

            }
            } 
        }
        }

       

        Tablero objtablero = new Tablero(ubicacionpieza, numpieza);
        objtablero.definirposiciones();
        objtablero.graficarPosiciones();
        objtablero.mostrar();
        objtablero.evaluarPosicionesRectas();
        objtablero.evaluarPosicioneshorizontales();
        objtablero.evaluarPosicionesdiagonales1();
        objtablero.evaluarPosicionesdiagonales2();
        





    }
}