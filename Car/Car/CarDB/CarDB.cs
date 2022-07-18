using CarModel.Car.CarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car.CarDB
{
    public class CarDB
    {

      
            public static List<AllSkillCar> list = new List<AllSkillCar>()
            {
            
            
            new AllSkillCar{Name="Ford", Antique=true, Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=1967, Price=20000 },
            new AllSkillCar{Name="Camaro", Antique=true, Capacity= 2, Color=CarColor.Blue, FuelType=FuelType.Gas, ModelYear=1973, Price=12000 },
            new AllSkillCar{Name="Chevrolet", Antique=true, Capacity= 5, Color=CarColor.White, FuelType=FuelType.Gas, ModelYear=1951, Price=40000 },
            new AllSkillCar{Name="Mercedes", Antique=true, Capacity= 4, Color=CarColor.Orange, FuelType=FuelType.Gas, ModelYear=1961, Price=27000 },
            new AllSkillCar{Name="Cadillac", Antique=true, Capacity= 2, Color=CarColor.Brown, FuelType=FuelType.Gas, ModelYear=1979, Price=11000 },
            new AllSkillCar{Name="Aston Martin", Antique=true, Capacity= 4, Color=CarColor.Yellow, FuelType=FuelType.Gas, ModelYear=1962, Price=30000 },
            new AllSkillCar{Name="Alfa Romeo", Antique=true, Capacity= 2, Color=CarColor.Brown, FuelType=FuelType.Gas, ModelYear=1965, Price=18000 },
            new AllSkillCar{Name="Porsche", Antique=true, Capacity= 2, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=1953, Price=15000 },
            new AllSkillCar{Name="Ferrari", Antique=true, Capacity= 4, Color=CarColor.Pink, FuelType=FuelType.Gas, ModelYear=1978, Price=12000 },
            new AllSkillCar{Name="Mini", Antique=true, Capacity= 4, Color=CarColor.White, FuelType=FuelType.Gas, ModelYear=1949, Price=40000 },

            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Sunroof=true},
            new AllSkillCar{Name="Ford", Capacity= 6, Color=CarColor.Brown, FuelType=FuelType.Diesel, ModelYear=2017, Price=13000,  Sunroof=false},
            new AllSkillCar{Name="Mercedes", Capacity= 5, Color=CarColor.Orange, FuelType=FuelType.Hybrid, ModelYear=2001, Price=12000,  Sunroof=true},
            new AllSkillCar{Name="Nissan", Capacity= 4, Color=CarColor.White, FuelType=FuelType.Electric, ModelYear=2005, Price=21000,  Sunroof=false},
            new AllSkillCar{Name="Kia", Capacity= 8, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2019, Price=6000,  Sunroof=true},
            new AllSkillCar{Name="Seat", Capacity= 7, Color=CarColor.Yellow, FuelType=FuelType.Electric, ModelYear=2015, Price=4000,  Sunroof=false},
            new AllSkillCar{Name="Skoda", Capacity= 5, Color=CarColor.Green, FuelType=FuelType.Hybrid, ModelYear=2022, Price=17000,  Sunroof=false},
            new AllSkillCar{Name="Wolkswagen", Capacity= 4, Color=CarColor.Purple, FuelType=FuelType.Diesel, ModelYear=2020, Price=12500,  Sunroof=true},
            new AllSkillCar{Name="Volvo", Capacity= 6, Color=CarColor.Red, FuelType=FuelType.Gas, ModelYear=2021, Price=7200,  Sunroof=true},
            new AllSkillCar{Name="Toyota", Capacity= 10, Color=CarColor.Yellow, FuelType=FuelType.Diesel, ModelYear=2012, Price=5120,  Sunroof=false},

            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Machine = 2 },

            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Tire="Winter"},

            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  TurboName="Nitro"},

            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            new AllSkillCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=2003, Price=8000,  Headlamps=200},
            };

          

       

        //List<AllSkillCar> clasicCarList = new List<AllSkillCar>()
        //{
          
        //};
        //List<AllSkillCar> hatchbagCarList = new List<AllSkillCar>()
        //{
          
        //};
        //List<AllSkillCar> roadCarList = new List<AllSkillCar>()
        //{
            
        //};
        //List<AllSkillCar> sedanCarList = new List<AllSkillCar>()
        //{
            
        //};
        //List<AllSkillCar> sportCarList = new List<AllSkillCar>()
        //{
           
        //};
        //List<AllSkillCar> suvCarList = new List<AllSkillCar>()
        //{
           

        //};

        //public List<Object> AllCarList()
        //{
        //    List<object> allCarList = new List<object>();
        //    allCarList.Add(suvCarList);
        //    allCarList.Add(sportCarList);
        //    allCarList.Add(sedanCarList);
        //    allCarList.Add(roadCarList);
        //    allCarList.Add(clasicCarList);
        //    allCarList.Add(hatchbagCarList);

        //    return allCarList;
        //}

       


    }
}
