using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3;

namespace Wrox
{

    public class Cars
    {
        public string WheelsCount;
        public string Model;
        public string MakeCountry;

        public int CheckCars()
        {
            int ch;
            if (Model == "Audi")
            {
                ch = 5;
            }
            else if (Model == "BMW")
            {
                ch = 335;
            }
            else
            {
                ch = 0;
            }
            return ch;
        }
        public Cars()
        {
            WheelsCount = "Four";
        }
    }

    class CarsForCustomer : Cars
    {
        public CarsForCustomer()
        {

            Model = "Audi";
            MakeCountry = "German";
        }
    }
    class CarsForMe : Cars
    {
        public CarsForMe()
        {
            WheelsCount = "Where";
            Model = "BMW";
            MakeCountry = "German";
        }
    }
    class CarsFoHe : Cars
    {
        public CarsFoHe()
        {
            WheelsCount = "Which";
            Model = "Mazda";
            MakeCountry = "Japan";
        }
    }
    class CarsFoShe : Cars
    {
        public CarsFoShe()
        {
            WheelsCount = "Who";
            Model = "Fiat";
            MakeCountry = "Italy";

        }
    }



    
    //public class ReadFile
    //{
    //    StreamReader fileTest = new StreamReader(@"c:\Test.txt");

    //    public string line;
    //    public ReadFile()
    //    {
    //       line = fileTest.ReadLine();
    //    }
    //}

}       
        
        

