using System;

namespace Juego_de_la_fortuna_examen_1
{
    class Program
    {
        static void Main(string[] args)
        {
           string[,] cadena = new string[5,5];
    

            string letras = "ABCD";
            string numero = "1234";
            //ganadores (casa)
            cadena[0,1]= "C";
            cadena[4,1]= "C";
            cadena[1,4]= "C";
            int casa = 0;

            //ganadores (auto)
            cadena[3,0]= "A";
            cadena[2,2]= "A";
            cadena[4,3]= "A";
            int auto = 0;

            //perdedores
            int perder = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (cadena[i,j] == "C" || cadena[i,j] == "A")
                    {
                        continue;   
                    }
                    cadena[i,j]= "X";
                }
            }
            
            int fila = 0;
            int columna = 0;

            while (true)
            {

                System.Console.WriteLine("SELECCIONE UNA CASILLA");
                string usuario=Console.ReadLine();
                string valor = usuario.ToUpper();
                //conversion
                char valor1 = valor[0];
                string valor2 = valor.Substring(1);
                //resultado
                
                fila = letras.IndexOf(valor1);
                columna = numero.IndexOf(valor2);

                try{
                if(cadena[fila,columna]=="A"){auto++;System.Console.WriteLine("A");}
                if(cadena[fila,columna]=="C"){casa++;System.Console.WriteLine("C");}
                if(cadena[fila,columna]=="X"){perder++;System.Console.WriteLine("X");}  
                }catch(Exception){
                    System.Console.WriteLine("CASILLA INVALIDA");
                } 

                if (auto==3){System.Console.WriteLine("GANASTE UN AUTO");break;}
                if (casa==3){System.Console.WriteLine("GANASTE UNA CASA");break;}
                if (perder==3){System.Console.WriteLine("HAS PERDIDO :(");break;}

            }
        }
    }
}
