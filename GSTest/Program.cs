using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GSTest
{
    class personData
    {
        public float ageOfDeath { get; set; }
        public float yearOfDeath { get; set; }
    }
    class Program
    {
        class expelTheWitch
        {
            public float getTotalVictims(float year)
            {
                if (year < 0) {
                    return -1;
                }
                if (year == 0) {
                    return 1;
                }
                int i = 0, cek, num = 2;
                List<int> victims = new List<int> { 1, 1 };
                
                

                while (victims.Count() <= year)
                {
                    cek = 0;
                    for (int j = 2; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            cek++;
                        }
                    }
                    if (cek == 1)
                    {
                        victims.Add(num);
                        
                        i++;                       
                    }
                    num++;
                }
                //victims.ForEach(i => Console.Write("{0} \t+", i));
                //Console.WriteLine("");
                return victims.Sum();

            }

            public float calculatePeopleDeath(personData persData)
            {
                float year = persData.yearOfDeath - persData.ageOfDeath;
                float currentYear = year - 1;
                float casualties = getTotalVictims(currentYear);
                return casualties;
            }

            public float calculateAverageDeath(List<personData> pData)
            {
                List<float> listOfCsualties = new List<float>();
                pData.ForEach(data => listOfCsualties.Add(calculatePeopleDeath(data)));
                Console.WriteLine("Average = ({0}/{1})", listOfCsualties.Sum(), pData.Count());
                float average = listOfCsualties.Sum() / pData.Count();
                return average;
            }
        }
        static void Main(string[] args)
        {
            List<personData> personDatas = new List<personData>();
           
            Console.Write("Input Age Of Death Person : ");
            string InputAge = Console.ReadLine();
            Console.Write("Input Year Of Death Person : ");
            string InputDeath = Console.ReadLine();
            expelTheWitch exp = new expelTheWitch();
            personData dataPerson = new personData();
            dataPerson.ageOfDeath = float.Parse(InputAge);
            dataPerson.yearOfDeath = float.Parse(InputDeath);
            personDatas.Add(dataPerson);

            
            personData dataPerson2 = new personData();
            Console.Write("Input Age Of Death Person 2 :");
            string InputAge2 = Console.ReadLine();
            Console.Write("Input Year Of Death Person 2 :");
            string InputDeath2 = Console.ReadLine();
            dataPerson2.ageOfDeath = float.Parse(InputAge2);
            dataPerson2.yearOfDeath = float.Parse(InputDeath2);
            personDatas.Add(dataPerson2);

            float casualties = exp.calculateAverageDeath(personDatas);
            Console.WriteLine("Average Of Death are {0}",casualties);

        }

    }
    
}
