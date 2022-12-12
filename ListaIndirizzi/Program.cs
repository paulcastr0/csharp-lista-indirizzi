// See https://aka.ms/new-console-template for more information
using ListaIndirizzi;

List<Indirizzo> listaIndirizzi = new List<Indirizzo>();

try
{
    StreamReader file = File.OpenText("C:\\Users\\Generation\\Desktop\\Nuova cartella\\OOP-Csharp\\ListaIndirizzi\\Indirizzi.txt");
    file.ReadLine();
    while (!file.EndOfStream)
    {
        string riga = file.ReadLine();


        string[] informazioniIndirizzo = riga.Split(",");

        string name = informazioniIndirizzo[0];
        string surname = informazioniIndirizzo[1];
        string street = informazioniIndirizzo[2];
        string city = informazioniIndirizzo[3];
        string state = informazioniIndirizzo[4];
        string zip = informazioniIndirizzo[5];

        Indirizzo indirizzoEstratto = new Indirizzo(name,surname,street,city,state,zip);
        listaIndirizzi.Add(indirizzoEstratto);

    }
    file.Close();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo);
}

