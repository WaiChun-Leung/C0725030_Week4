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
            //LearningExample L = new LearningExample();
            //L.run();

        }
    }

    //this part is just for check a and b is it store in the same location
    //class LearningExample
    //{
    //    public void run()
    //    {
    //        Village Toronto;
    //        Village a;
    //        Village b;
    //        Toronto = new Village();
    //        a = Toronto;

    //        Toronto = new Village();
    //        b = Toronto;

    //        if (a == b)
    //        {
    //            Console.WriteLine("Same");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Different object refs");
    //        }
    //    }        
    //}

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

            Ajax = new Village();
            Toronto = new Village();
            Maple = new Village();

            //make the name of village
            Maple.VillageName = "Maple";
            Maple.previousVillage = null;
            //hoot up to all the city
            Maple.nextVillage = Toronto;
            Ajax.isAstrildeHere = true;
            
            Toronto.previousVillage = Maple;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousVillage = Toronto;

            //to check Hugi here or not
            //Ajax.isAstrildeHere = true;
        }

        //make another for Hugi travel
        public void LookForAstrilde()
        {
            Current = Maple;

            while (Current.nextVillage != null)
            {
                if (Current.isAstrildeHere)
                {
                    Console.WriteLine("Found Astrilde");
                    return;
                }
                else
                {
                    Current = Current.nextVillage;
                }
            }


            //Head = Maple; //class Head the reference is Maple            
            //if (Head.isAstrildeHere)
            //{
            //    Console.WriteLine("Yeah ! Astrilde is in " + Head.VillageName);
            //}

            //while (true) //use tap 2 time will show (true)
            //{

            //}
        }
    }
}
