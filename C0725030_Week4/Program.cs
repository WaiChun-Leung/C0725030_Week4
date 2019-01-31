using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725030_Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside Ontario = new Countryside();
            Ontario.run();

        }
    }

    class Village
    {
        public static int numberOfVillages = 0; //to know how many village have
        public Village nextVillage;
        public Village previousVillage;
        public string VillageName;
        public bool isAstrildeHere = false;

        public Village()
        {
            Village.numberOfVillages++;
        }
    }

    //collection of all the data point of all the villages

    class Countryside //this is a sociation - "has a"
    {
        //all is object, is class instance
        public Village Maple;
        public Village Toronto;
        public Village Ajax;
        public Village Head;
        public Village Tail;
        public Village Temp;
        public Village Current;

        public void run()
        {
            this.MapInitializer();
            this.LookForAstrilde();
            Console.WriteLine("Hugi found Astrilde in " + Current.VillageName);
        }

        //make a method
        public void MapInitializer()
        {
            //is the linked list
            //new operator

            Maple = new Village();
            //make the name of village
            Maple.VillageName = "Maple";
            Maple.previousVillage = null;
            //hoot up to all the city
            Maple.nextVillage = Toronto;
            Maple.isAstrildeHere = true;
            Toronto = new Village();
            Toronto.previousVillage = Maple;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Ajax = new Village();
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;

            //to check Hugi here or not
            //Ajax.isAstrildeHere = true;
        }

        //make another for Hugi travel
        public void LookForAstrilde()
        {
            Current = Maple; //class Head the reference is Maple            
            //if (Head.isAstrildeHere)
            //{
            //    Console.WriteLine("Yeah ! Astrilde is in " + Head.VillageName);
            //}

            while (Current.nextVillage != null) //use tap 2 time will show (true)
            {
                if (Current.isAstrildeHere)
                {
                    Console.WriteLine("Found Astrilde");
                }
            }
        }
    }
}
