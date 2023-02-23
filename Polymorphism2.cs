using System;

public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     familyhobi adik = new Adik();
     
     familydata ayahku = new familydata("Tyo",64,+6281330363201);
    familydata ibuku = new familydata("Ratna",43,+6281939710489);
    familydata aku = new familydata("Moch.Febriyan H",16,+62882009691450);
    familydata adikk = new familydata("Mita",10,+6285748347289);
     Console.WriteLine("data ayah:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("data ibu:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("data anak:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
     Console.WriteLine("data adikk:\n"+adikk.nama+"\n"+adikk.umur+"\n"+adikk.nohp);
     
     
        

    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
       
        
        
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Olahraga");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Memasak");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Menonton kartun");
        }
    }
    class Adik:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Makan");
        }
    }
    

}
