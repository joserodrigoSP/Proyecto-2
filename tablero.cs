namespace Proyecto_2;

public class Tablero
{
   public int validar;
    public string[,] ltablero = new string[8,8];
    public string[,] posiciones = new string[8,8];
    public string[,] matrizensenar = new string[8,8];
    public Tablero(string[,] ubicaciones, int val){
        this.ltablero = ubicaciones;
        this.validar = val;
    }
    public void definirposiciones(){
      for(int i=0; i<posiciones.GetLength(0); i++){
            for(int j=0; j<posiciones.GetLength(1); j++){
                posiciones[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j);  //DEFINE LAS POSICIONES EN NOTACION DE AJEDREZ
        }
        }


         for(int i=0; i<matrizensenar.GetLength(0); i++){
            for(int j=0; j<matrizensenar.GetLength(1); j++){
                matrizensenar[0+i,j]= ""+Convert.ToChar(97+i)+Convert.ToChar(49+j)+"   |";//DEFINE LAS POSICIONES EN NOTACION DE AJEDREZ
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
            if(ltablero[i,j].Contains("dama blanca")){ //verifica la ubicacion de la dama blanca
               pos1=i;
               pos2=j;
               pos3=j;
               valor = 7-j;
               vap = 8-valor;
                  if(this.validar==0){ 
                     for(int m=0; m<=valor; m++){ 
                        if(!(ltablero[i,j+m].Contains("blanco") || ltablero[i,j+m].Contains("negro"))){
                           Console.WriteLine("| la pasicion es: "+ posiciones[i,j+m]);

                        }
                     }
                     q=j;
                   while(!(ltablero[i,q].Contains("blanco") || ltablero[i,q].Contains("negro")) && q>=1){
                     Console.WriteLine("| la pasicion es: "+ posiciones[i,q-1]);
                     q--;
                   }



                  }else{ ////////////////////////// Cuando el tablero no es blanco ni es negro y no pasa de los valores entonces pasa lo que está adentro del bloque
                  while(!(ltablero[i,pos2].Contains("blanco") || ltablero[i,pos2].Contains("negro"))  && k<valor && pos2<7){
                     if(ltablero[i,pos2+1].Contains("blanco")){
                  pos2++;k++;
                  }else{
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos2+1]);
                  pos2++;k++;
                  }
                  }
                  if(ltablero[i,pos2].Contains("negro")){ // coomo evalua solo hasta la posicion 6 imprimimos la posicion 7 
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos2]);
                  }


                   while(!(ltablero[i,pos3].Contains("blanco") || ltablero[i,pos3].Contains("negro")) && p<=vap &&pos3>0){
                     if(ltablero[i,pos3-1].Contains("blanco")){
                       pos3--;p++;
                     }else{
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos3-1]);
                     pos3--;p++;
                     }
                  
                  }
                  if(ltablero[i,pos3].Contains("negro")){
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos3]);
                  }
                  }



            } else if(ltablero[i,j].Contains("dama negra")){ ///////////////////////////// EVALUAMOS, ES DECIR HACEMOS LO MISMO PERO CON LA DAMA NEGRA//



               pos1=i;
               pos2=j;
               pos3=j;
               valor = 7-j;
               vap = 8-valor;
                  if(this.validar==0){
                     for(int m=0; m<=valor; m++){
                        if(!(ltablero[i,j+m].Contains("blanco") || ltablero[i,j+m].Contains("negro"))){
                           Console.WriteLine("| la pasicion es: "+ posiciones[i,j+m]);

                        }
                     }
                     q=j;
                   while(!(ltablero[i,q].Contains("blanco") || ltablero[i,q].Contains("negro")) && q>=1){
                     Console.WriteLine("| la pasicion es: "+ posiciones[i,q-1]);
                     q--;
                   }



                  }else{
                  while(!(ltablero[i,pos2].Contains("blanco") || ltablero[i,pos2].Contains("negro"))  && k<valor && pos2<7){
                     if(ltablero[i,pos2+1].Contains("negro")){
                  pos2++;k++;
                  }else{
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos2+1]);
                  pos2++;k++;
                  }
                  }
                  if(ltablero[i,pos2].Contains("blanco")){
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos2]);
                  }


                   while(!(ltablero[i,pos3].Contains("blanco") || ltablero[i,pos3].Contains("negro")) && p<=vap &&pos3>0){
                     if(ltablero[i,pos3-1].Contains("negro")){
                       pos3--;p++;
                     }else{
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos3-1]);
                     pos3--;p++;
                     }
                  
                  }
                  if(ltablero[i,pos3].Contains("blanco")){
                     Console.WriteLine("| la posicion es: "+ posiciones[i,pos3]);
                  }
                  }

            }
      
            }
            }
            }


            public void evaluarPosicioneshorizontales(){
               int posuno=0, posdos=0, postres=0,valor=0,res=0;
               int posuno_=0, posdos_=0, postres_=0,valor_=0,res_=0;

               for(int i=0; i<ltablero.GetLength(0);i++){
                  for(int j=0; j<ltablero.GetLength(1); j++){
                     if(ltablero[i,j].Contains("dama blanca")){
                         posuno =i;
                         posdos =j;
                         postres =i;
                         valor = 7-i;
                         res =0;
                         while(posuno<8 && !ltablero[posuno,posdos].Contains("blanco")&& !ltablero[posuno,posdos].Contains("negro")){
                           if(ltablero[posuno,posdos].Contains("dama blanca")){
                              posuno++;
                           }else{
                           Console.WriteLine("-La posicion es: "+posiciones[posuno,posdos]);posuno++;
                           }
                         }if(!ltablero[posuno-1,posdos].Contains("blanco") && !ltablero[posuno-1,posdos].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[posuno-1,posdos]);
                         }else if(ltablero[posuno-1,posdos].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[posuno-1,posdos]);
                         }

                         while(postres>=0 && !ltablero[postres,posdos].Contains("blanco")&& !ltablero[postres,posdos].Contains("negro")){
                           if(ltablero[postres,posdos].Contains("dama blanca")){postres--;}else{
                           Console.WriteLine("-La posicion es: "+posiciones[postres,posdos]);postres--;}
                         }if(!ltablero[postres+1,posdos].Contains("blanco")&& !ltablero[postres+1,posdos].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[postres+1,posdos]);
                         }else if(ltablero[postres+1,posdos].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[postres+1,posdos]);
                         }

                    
                        }

                         if(ltablero[i,j].Contains("dama negra")){
                         posuno_ =i;
                         posdos_ =j;
                         valor_ = 7-i;
                         postres_ =i;
                         while(posuno_<8 && !ltablero[posuno_,posdos_].Contains("blanco")&& !ltablero[posuno_,posdos_].Contains("negro")){
                           if(ltablero[posuno_,posdos_].Contains("dama")){posuno_++;}else{
                           Console.WriteLine("-La posicion es: "+posiciones[posuno_,posdos_]);posuno_++;}
                         }if(!ltablero[posuno_-1,posdos_].Contains("blanco")&& !ltablero[posuno_-1,posdos_].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[posuno_-1,posdos_]);
                         }else if(ltablero[posuno_-1,posdos_].Contains("blanco")){
                           Console.WriteLine("-La posicion es: "+posiciones[posuno_-1,posdos_]);
                         }

                         while(postres_>=0 && !ltablero[postres_,posdos_].Contains("blanco")&& !ltablero[postres_,posdos_].Contains("negro")){
                              if(ltablero[postres_,posdos_].Contains("dama")){postres_--;}else{
                           Console.WriteLine("-La posicion es: "+posiciones[postres_,posdos_]);postres_--;}
                         }if(!ltablero[postres_+1,posdos_].Contains("blanco") && !ltablero[postres_+1,posdos_].Contains("negro")){
                           Console.WriteLine("-La posicion es: "+posiciones[postres_+1,posdos_]);
                         }else if(ltablero[postres_+1,posdos_].Contains("blanco")){
                           Console.WriteLine("-La posicion es: "+posiciones[postres_+1,posdos_]);
                         }
                        
                        }

                        

                     }
                  }
               }



   public void evaluarPosicionesdiagonales1(){

      for(int i=0; i<ltablero.GetLength(0); i++){
         for(int j=0; j<ltablero.GetLength(1); j++){
            int p1 = j;
            int p0=i;
            int pav1=i;
            int pav2=j;
            int p1_ = j;
            int p0_=i;
            int pav1_=i;
            int pav2_=7-j;
            int valorabs;
            if(ltablero[i,j].Contains("dama blanca")){
               string pdam ="";
               while( pav2>=0 && p0<8 && p1>=0 && !ltablero[p0,p1].Contains("blanco") && !ltablero[p0,p1].Contains("negro") ){

                 if(ltablero[p0,p1].Contains("dama")){
                  pdam = ltablero[p0,p1];

                 } if(pdam == ltablero[p0,p1]){
                  pav1--;pav2--; p1--;p0++;
                 }else{
                Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                  pav1--;pav2--; p1--;p0++;
                 }
               }/*if(ltablero[p0,p1].Contains("negro")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                  }*/


               string pdam2="";
               
                while(p0_>=0 && p1_<8 && !ltablero[p0_,p1_].Contains("blanco") && !ltablero[p0_,p1_].Contains("negro")){
                  if(ltablero[p0_,p1_].Contains("dama")){
                     pdam2 = ltablero[p0_,p1_];
                  }
                  if(pdam2 == ltablero[p0_,p1_]){
                  pav1_--;pav2_--; p1_++;p0_--;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                     pav1_--;pav2_--; p1_++;p0_--;
                  }

               }
               
               
               /*if(ltablero[p0_,p1_].Contains("negro")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                  }*/
                  // fin dama blanca posiciones en diagonal 


               


            }


             if(ltablero[i,j].Contains("dama negra")){
               string pdam ="";
               while( pav2>=0 && p0<8 && p1>=0 && !ltablero[p0,p1].Contains("blanco") && !ltablero[p0,p1].Contains("negro") ){

                 if(ltablero[p0,p1].Contains("dama")){
                  pdam = ltablero[p0,p1];

                 } if(pdam == ltablero[p0,p1]){
                  pav1--;pav2--; p1--;p0++;
                 }else{
                Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                  pav1--;pav2--; p1--;p0++;
                 }
               }/*if(ltablero[p0,p1].Contains("blanco")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                  }*/


               string pdam2="";
               
                while(  p0_>=0 && p1_<8 && !ltablero[p0_,p1_].Contains("blanco") && !ltablero[p0_,p1_].Contains("negro")){
                  if(ltablero[p0_,p1_].Contains("dama")){
                     pdam2 = ltablero[p0_,p1_];
                  }
                  if(pdam2 == ltablero[p0_,p1_]){
                  pav1_--;pav2_--; p1_++;p0_--;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                     pav1_--;pav2_--; p1_++;p0_--;
                  }

               }/*if(ltablero[p0_,p1_].Contains("blanco")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                  }*/
                  // fin dama blanca posiciones en diagonal 


               


            }

         }     
      }


   }







   public void evaluarPosicionesdiagonales2(){

      for(int i=0; i<ltablero.GetLength(0); i++){
         for(int j=0; j<ltablero.GetLength(1); j++){
           
            if(ltablero[i,j].Contains("dama blanca")){
               string pdam ="";
                int p1 = j;
            int p0=i;
            int pav1=i;
            int pav2=j;
            int p1_ = j;
            int p0_=i;
            int p1__ = j;
            int p0__=i;
            int pav1_=i;
            int pav2_=7-j;
            int valorabs;
            string pdam2="";
               
                while( p0_>=0 && p1_>=0 && !ltablero[p0_,p1_].Contains("blanco") && !ltablero[p0_,p1_].Contains("negro")){
                  if(ltablero[p0_,p1_].Contains("dama")){
                     pdam2 = ltablero[p0_,p1_];
                  }
                  if(pdam2 == ltablero[p0_,p1_]){
                  pav1_--;pav2_--; p1_--;p0_--;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                     pav1_--;pav2_--;p1_--;p0_--;
                  }

               }/*if(ltablero[p0_,p1_].Contains("negro")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                  }*/
                  // fin dama blanca posiciones en diagonal 


                 string pdam2_="";
               
                while(p0__<8 && p1__<8){
                  if( !(ltablero[p0__,p1__].Contains("blanco") || ltablero[p0__,p1__].Contains("negro"))){
                  if(ltablero[p0__,p1__].Contains("dama")){
                     pdam2_ = ltablero[p0__,p1__];
                  }
                  if(pdam2_ == ltablero[p0__,p1__]){
                  pav1_--;pav2_--; p1__++;p0__++;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0__,p1__]);
                     pav1_--;pav2_--;p1__++;p0__++;
                  }

               }else if(ltablero[p0__,p1__].Contains("negro")){
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0__,p1__]);
                    pav1_--;pav2_--;p1__++;p0__++;

               }
               
               }/*if(ltablero[p0_,p1_].Contains("blanco")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                  }*/
                  // fin dama blanca posiciones en diagonal 





            }


             if(ltablero[i,j].Contains("dama negra")){
                int p1 = j;
            int p0=i;
            int pav1=i;
            int pav2=j;
            int p1_ = j;
            int p0_=i;
            int pav1_=i;
            int pav2_=7-j;
            int valorabs;
                         string pdam ="";
                   
                while(p0>=0 && p1>=0){
                  if( !(ltablero[p0,p1].Contains("blanco") || ltablero[p0,p1].Contains("negro"))){
                  if(ltablero[p0,p1].Contains("dama")){
                     pdam = ltablero[p0,p1];
                  }
                  if(pdam == ltablero[p0,p1]){
                  pav1--;pav2--; p1--;p0--;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                     pav1--;pav2--;p1--;p0--;
                  }

               }else if(ltablero[p0,p1].Contains("blanco")){
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                    pav1--;pav2--;p1--;p0--;

               }
               
               }/*if(ltablero[p0,p1].Contains("blanco")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0,p1]);
                  }*/


               string pdam2="";
               
                while(p0_<8 && p1_<8){
                  if( !(ltablero[p0_,p1_].Contains("blanco") || ltablero[p0_,p1_].Contains("negro"))){
                  if(ltablero[p0_,p1_].Contains("dama")){
                     pdam2 = ltablero[p0_,p1_];
                  }
                  if(pdam2 == ltablero[p0_,p1_]){
                  pav1_--;pav2_--; p1_++;p0_++;
                  }else{
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                     pav1_--;pav2_--;p1_++;p0_++;
                  }

               }else if(ltablero[p0_,p1_].Contains("blanco")){
                     Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                    pav1_--;pav2_--;p1_++;p0_++;

               }
               
               }/*if(ltablero[p0_,p1_].Contains("blanco")){
                   Console.WriteLine("/ Las posiciones son: "+posiciones[p0_,p1_]);
                  }*/
                  // fin dama blanca posiciones en diagonal 



               


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
    
    /* */
    
    public void graficarPosiciones(){
         for(int i = 0; i < posiciones.GetLength(0); i++){
         for(int z=0;  z< posiciones.GetLength(1); z++) {
           switch(ltablero[i,z]){
            case "dama blanca":
            matrizensenar[i,z] ="DB👵🏽| ";
            break;
            case "dama negra":
            matrizensenar[i,z] ="DN👵🏽| ";
            break;
             case "alfil blanco":
            matrizensenar[i,z] ="AB🐁| ";
            break;
            case "alfil negro":
            matrizensenar[i,z] ="AN🐀| ";
            break;
             case "peon blanco":
            matrizensenar[i,z] ="PB👻| ";
            break;
            case "peon negro":
            matrizensenar[i,z] ="PN🕴🏽| ";
            break;
             case "caballo blanco":
            matrizensenar[i,z] ="CB🦓| ";
            break;
            case "caballo negro":
            matrizensenar[i,z] ="CN🐎| ";
            break;
             case "torre blanco":
            matrizensenar[i,z] ="TB🏦| ";
            break;
            case "torre negro":
            matrizensenar[i,z] ="TN🏛️| ";
            break;
            
           }
}

        }
        }


    
    
    

    public void mostrar(){
          for(int i = 0; i < posiciones.GetLength(0); i++){
         for(int z=0;  z< posiciones.GetLength(1); z++) {
            Console.Write("       " + matrizensenar[z,i]);
        }
        Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
        }
    }
    
    }

