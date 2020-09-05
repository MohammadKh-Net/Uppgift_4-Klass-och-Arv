using System;


namespace Uppgift_4
{
    class Djur //Basklass
    {   //Klass attribute
        private string _namn;
        private string _färg;
        

        public string Namn
        {  
            get { return _namn; }
            set { _namn = value; }

        }
        public string Färg
        {
            get { return _färg; }
            set { _färg = value; }
        }
        

    }
    class Gräsätare: Djur // Deriverad klass (child)
    {
        
        public virtual void ljud()
        {
            Console.WriteLine("jag låter så här!");
        }

    }
    class Köttätare: Djur // Deriverad klass (child)
    {
        
        public virtual void ljud() // "Virtual" Method som kan återanvändas i andra klasser.
        {
            
            Console.WriteLine("Jag låter så här!");
        }

    }
    class Lejon:Köttätare
    {
        public Lejon() //konstruktor som ger ett värde till den ärvda variabeln.
        {
            this.Namn = "Namn är: Lejon, ";
        }
        
        public override void ljud() //Återanväd method som beskriver djurens röst.
        {
            Console.WriteLine("Lejon, låter så här,Aoww Aoww!");
        }

    }
    class Ko : Gräsätare
    {
        public Ko() //konstruktor som ger ett värde till den ärvda variabeln.
        {
            this.Namn = "Namn: Ko, ";
        }  
        public override void ljud() //Återanväd method som beskriver djurens röst.
        {
          Console.WriteLine("Ko, låter så här,AAAMMMM");  
        }
        
    }
    class Får : Gräsätare
    {
        public Får() //konstruktor som ger ett värde till den ärvda variabeln.
        {
            this.Namn = "Namn: Får,";
        }
        public override void ljud() //Återanväd method som beskriver djurens röst.
        {
            Console.WriteLine("Får, Låter så här, BÄÄÄÄ, BÄÄÄÄÄÄ");
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            
           
            Lejon lejon = new Lejon(); //Ett objekt från klasen Lejon.
            Ko ko = new Ko(); //Ett objekt från klasen Ko.
            Får får = new Får(); //Ett objekt från klasen Får.

            Console.WriteLine(lejon.Namn); //Skriver ut Namnet
            lejon.ljud(); //Kallar ljud funktionen som tillhör Lejon klassen.
            Console.WriteLine(ko.Namn);
            ko.ljud(); //Kallar ljud funktionen som tillhör Ko klassen.
            Console.WriteLine(får.Namn);
            får.ljud(); //Kallar ljud funktionen som tillhör Får klassen.






            Console.ReadKey();

            

        }
    }
}
