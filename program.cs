using static System.Console;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        
        Actions();
        
        WriteLine($"Tempo passado: {stopwatch.Elapsed}");
        
        
        
        stopwatch.Stop();
    }
    

    public static void Actions()
    {
        int garbage = 0;
        int conttot = 0;
        int contrelev = 0;
        int contfor = 0;
        int j = 1;
        int k = 1;
        int contWhile = 0;
        int contwhile2 = 1;
        int contfor2 = 0;
        for ( var i = 0;i < 5000; i ++)
        {
            contfor = contfor+1;
            conttot = conttot + 1;
            WriteLine($"número de ações do for 1: {contfor}");
            
            {
                
                if (contfor == 1)
                {
                    contrelev = contrelev + 1;

                    contfor = contfor + 100;

                }
                else
                {
                    garbage = garbage + 1;

                }
                if (contfor == 200)
                {

                    contfor = contfor + 100;
                    contrelev = contrelev + 1;
                }
                else
                {
                    garbage = garbage + 1;
                }
                if (contfor == 1)
                {
                    contrelev = contrelev + 1;

                    contfor = contfor + 100;

                }
                else
                {
                    garbage = garbage + 1;

                }
                if (contfor == 200)
                {

                    contfor = contfor + 100;
                    contrelev = contrelev + 1;
                }
                else
                {
                    garbage = garbage + 1;
                }
                if (contfor == 1)
                {
                    contrelev = contrelev + 1;

                    contfor = contfor + 100;

                }
                else
                {
                    garbage = garbage + 1;

                }
                if (contfor == 200)
                {

                    contfor = contfor + 100;
                    contrelev = contrelev + 1;
                }
                else
                {
                    garbage = garbage + 1;
                }
            }
                if (contfor == 1)
            {
                contrelev = contrelev + 1;

                contfor = contfor + 100;

            }
                else
            {
                garbage = garbage + 1;

            }
                 if (contfor == 200)
            {

                contfor = contfor + 100;
                contrelev = contrelev + 1;
            }
                 else
            {
                garbage = garbage + 1;
            }
                 if (contfor == 1)
            {
                contrelev = contrelev + 1;

                contfor = contfor + 100;

            }
                 else
            {
                garbage = garbage + 1;

            }
                 if (contfor == 200)
            {

                contfor = contfor + 100;
                contrelev = contrelev + 1;
            }
                 else
            {
                garbage = garbage + 1;
            }
        }
        for (var l = 0; l < 5000; l++)
        {
            contfor2 = contfor2 + 1;
            conttot = conttot + 1;
            WriteLine($"número de ações do for 2: {contfor2}");
            if (contfor2 == 1)
            {
                contrelev = contrelev + 1;

                contfor2 = contfor2 + 100;

            }
            else
            {

                garbage = garbage + 1;
            }
            if (contfor2 == 200)
            {

                contfor2 = contfor2 + 100;
                contrelev = contrelev + 1;
            }
            else
            {
                garbage = garbage + 1; 
            }
            if (contfor2 == 1)
            {
                contrelev = contrelev + 1;

                contfor2 = contfor2 + 100;

            }
            else
            {

                garbage = garbage + 1;
            }
            if (contfor2 == 200)
            {

                contfor2 = contfor2 + 100;
                contrelev = contrelev + 1;
            }
            else
            {
                garbage = garbage + 1;
            }
            if (contfor2 == 1)
            {
                contrelev = contrelev + 1;

                contfor2 = contfor2 + 100;

            }
            else
            {

                garbage = garbage + 1;
            }
            if (contfor2 == 200)
            {

                contfor2 = contfor2 + 100;
                contrelev = contrelev + 1;
            }
            else
            {
                garbage = garbage + 1;
            }
            if (contfor2 == 1)
            {
                contrelev = contrelev + 1;

                contfor2 = contfor2 + 100;

            }
            else
            {

                garbage = garbage + 1;
            }
            if (contfor2 == 200)
            {

                contfor2 = contfor2 + 100;
                contrelev = contrelev + 1;
            }
            else
            {
                garbage = garbage + 1;
            }
            if (contfor2 == 1)
            {
                contrelev = contrelev + 1;

                contfor2 = contfor2 + 100;

            }
            else
            {

                garbage = garbage + 1;
            }
            if (contfor2 == 200)
            {

                contfor2 = contfor2 + 100;
                contrelev = contrelev + 1;
            }
            else
            {
                garbage = garbage + 1;
            }
        } 

        while(j < 5000)
        {
            j = j + 1;
            contWhile = contWhile + 1;
            conttot = conttot + 1;
            WriteLine($"numero de ações while 1: {contWhile}");
        }
        while (k < 5000)
        {
            k = k + 1;
            contwhile2 = contwhile2 + 1;
            conttot = conttot + 1;
            WriteLine($"numero de ações while 2: {contwhile2}");
        }

       
        WriteLine($"total de ações: {conttot}");
        WriteLine($"ações relevantes: {contrelev}");
    }
    


}
