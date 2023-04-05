using Polimorfizm.MojeKlasy;

static void Main(string[] args)
{

    Klient klient = new Klient("iaufhasdf", new DateTime(1-5-2004), "Tgfg", "sdfsdf", 6); 
    Console.WriteLine(klient.ToString());

    KlientOsoba osoba = new KlientOsoba("sdf", "nazwisk", new DateTime (6-1-2009), "wof", "heuirgh", "fgdg",3);

    KlientFirma firma = new KlientFirma("sdof", "telef", "ajif", "foih", "sdoinf", 4);
}