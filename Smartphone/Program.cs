ISmartphone hpBudi = new Iphone();

Fotografer fotografer = new Fotografer();
fotografer.Kerja(hpBudi);

hpBudi = new Samsung();
fotografer.Kerja(hpBudi);

interface ISmartphone
{
    public void AmbilFoto();
}

class Iphone : ISmartphone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan sensor kamera premium ... Cekrek");
    }
   
}

class Samsung : ISmartphone
{
    public void AmbilFoto()
    {
        Console.WriteLine("Mengaktifkan fitur beauty ... Cekrek");
    }
}

class Fotografer
{
    public void Kerja(ISmartphone Hp)
    {
        Hp.AmbilFoto();
    }
}