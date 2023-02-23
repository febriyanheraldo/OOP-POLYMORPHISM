class Keluarga
{
    public virtual void nama()
    {
        Console.WriteLine("nama");
    }
    public virtual void umur()
    {
        Console.WriteLine("umur");
    }

    public virtual void noHP()
    {
        Console.WriteLine("no HP");
    }

    public virtual void hobi()
    {
        Console.WriteLine("hobi");
    }

    public void enter()
    {
        Console.WriteLine("");
    }

}
class Ayah : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Ayah : Tyo");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 64");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 083599726401");
    }
    public override void hobi()
    {
        Console.WriteLine("hobi : Olahraga");
    }
}
class Ibu : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Ibu : ratna");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 43");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 081939710489");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi : Memasak");
    }
}
class Aku : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Namaku : Moch.Febriyan Heraldo");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 16");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 0882009691450");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi :  Mendengarkan Musik");
    }
} 

class Adik : Keluarga
{
    public override void nama()
    {
        Console.WriteLine("Nama Adik : Mita");
    }
    public override void umur()
    {
        Console.WriteLine("Umur : 10");
    }
    public override void noHP()
    {
        Console.WriteLine("No HP : 085748347289");
    }
    public override void hobi()
    {
        Console.WriteLine("Hobi :  Makan");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Keluarga myKeluarga = new Keluarga();
        Keluarga myAyah = new Ayah();
        Keluarga myIbu = new Ibu();
        Keluarga myAku = new Aku();
        Keluarga myAdik = new Adik();

        
        myAyah.nama();
        myAyah.umur();
        myAyah.noHP();
        myAyah.hobi();
        myKeluarga.enter();
        myIbu.nama();
        myIbu.noHP();
        myIbu.umur();
        myIbu.hobi();
        myKeluarga.enter();
        myAku.nama();
        myAku.noHP();
        myAku.umur();
        myAku.hobi();
        myKeluarga.enter();
        myAdik.nama();
        myAdik.noHP();
        myAdik.umur();
        myAdik.hobi();
        myKeluarga.enter();
    }
}
