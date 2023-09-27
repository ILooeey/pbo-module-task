using System;

public class Laptop
{
    public string Merk { get; set; }
    public string Tipe { get; set; }
    public string vga { get; set; }
    public string processor { get; set; }

    public void setMerk(string merk)
    {
        Merk = merk;
        Console.WriteLine("Merk Laptop  : " + Merk);

    }
    public void setTipe(string tipe)
    {
        Tipe = tipe;
        Console.WriteLine("Tipe         : " +tipe);
    }
    public void setVga(string vga)
    {
        Console.WriteLine("VGA          : " + vga);

    }

    public void setProcessor(string processor)
    {
        Console.WriteLine("Processor    : " +processor);

    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");

    }
}
public class nyalamati
{
    static void Main()
    {
        AMD amd = new AMD();
        Asus asus = new Asus();
        Vivobook vivobook = new Vivobook();
        Nvidia NVIDIA = new Nvidia();
        CoreI5 corei5 = new CoreI5();
        asus.setMerk(asus.Merk);
        asus.setTipe(vivobook.Tipe);
        asus.setVga(NVIDIA.Merk);
        asus.setProcessor(corei5.Tipe);

        //Laptop laptop1 = new Laptop();
        Laptop laptop1 = new Vivobook();
        laptop1.Tipe = asus.Tipe;
        laptop1.vga = asus.vga;
        laptop1.processor = asus.processor;

        ((Vivobook)laptop1).Ngoding();

        Lenovo lenovo = new Lenovo();
        Ryzen ryzen = new Ryzen();
        IdeaPad ideaPad = new IdeaPad();    
        //lenovo.setMerk(lenovo.Merk);
        //lenovo.setTipe(ideaPad.Tipe);
        //lenovo.setVga(amd.Tipe);
        //lenovo.setProcessor(ryzen.Tipe);


        //Laptop laptop2 = new Laptop();
        //laptop2.Merk = lenovo.Merk;
        //laptop2.Tipe = lenovo.Tipe;
        //laptop2.vga = lenovo.vga;
        //laptop2.processor = lenovo.processor;

        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();

        
        //predator Predator = new predator();
        CoreI7 corei7 = new CoreI7();

        //Asus Predator = new Asus();
        
        //Predator.setMerk(Predator.Merk);
        //Predator.setTipe(Predator.Tipe);
        //Predator.setVga(amd.Tipe);
        //Predator.setProcessor(corei7.Tipe);

        //Predator.Merk = Predator.Merk;
        //Predator.Tipe = Predator.Tipe;
        //Predator.vga = Predator.vga;
        //Predator.processor = Predator.processor;

        //Predator.LaptopDinyalakan();
        //Predator.LaptopDimatikan();


        ACER acer = new predator();
        //acer.Merk = Predator.Merk;
        //acer.Tipe = Predator.Tipe;
        //acer.vga = Predator.vga;
        //acer.processor = Predator.processor;
        ((predator)acer).BermainGame();

    }
}

public class predator : ACER    
{
    public string Tipe = "Predator";

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }


}
public class Asus : Laptop
{

    public string Merk = "ASUS";
 
}

public class ROG : Asus
{
    public string Tipe = "ROG";
}

public class Lenovo : Laptop
{

    public string Merk = "Lenovo";
}

public class IdeaPad : Lenovo
{
    public string Tipe = "IdeaPad";

}
public class Vivobook : Asus
{
    public string Tipe = "Vivobook";
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

public class Legion
{
    public string Merk = "Legion";
}
public class swift
{
    public string Tipe = "Swift";
}
public class ACER : Laptop
{

    public string Merk = "ACER";
}

public class Processor
{
    public string Merk;
    public string Tipe;
}

public class Intel : Processor
{
    public string Merk = "Intel";
}

public class AMD : Processor
{
    public string Tipe = "AMD";
}

public class Vga 
{
    public string Merk;
}

public class AMd : Vga
{
    public string Merk  = "AMD";
}

public class Ryzen : AMd
{
    public string Tipe =  "RYZEN ";
}

public class Athlon : AMd
{
    public string Tipe = "ATHLON";
}

public class Nvidia : Vga
{
    public string Merk = "Nvidia";
}

public class CoreI3 : Intel
{
    public string Tipe = "Core i3";
}

public class CoreI5: Intel
{
    public string Tipe = "Core i5";
}

public class CoreI7 : Intel
{
    public string Tipe = "Core i7";
}

