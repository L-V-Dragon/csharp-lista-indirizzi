using csharp_lista_indirizzi;
using System;
using System.Linq.Expressions;


    string pathfile = "D:\\EserciziGIT\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\indirizzi.csv";
    StreamReader file = File.OpenText(pathfile);
    List<Indirizzo> indirizzi = new List<Indirizzo>();

    file.ReadLine();

    while (!file.EndOfStream)
    {
        string row = file.ReadLine();

        string[] rowArray = row.Split(",");

        if (rowArray.Length >= 6)
        {
            Indirizzo address = new Indirizzo(rowArray[0], rowArray[1], rowArray[2], rowArray[3], rowArray[4], rowArray[5]);
            indirizzi.Add(address);
        }

        

    }

foreach (Indirizzo address in indirizzi)
{
    Console.WriteLine(address);
}






