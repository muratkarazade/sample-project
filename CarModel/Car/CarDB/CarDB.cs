using CarModel.Car.CarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModel.Car.CarDB
{
    public  class CarDB
    {
        List<ClasicCar> clasicCarList = new List<ClasicCar>()
        {
            new ClasicCar{Name="Ford", Antique=true, Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1967"), Price=20000, Type= CarType.Clasic },
            new ClasicCar{Name="Camaro", Antique=true, Capacity= 2, Color=CarColor.Blue, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1973"), Price=12000, Type= CarType.Clasic },
            new ClasicCar{Name="Chevrolet", Antique=true, Capacity= 5, Color=CarColor.White, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1951"), Price=40000, Type= CarType.Clasic },
            new ClasicCar{Name="Mercedes", Antique=true, Capacity= 4, Color=CarColor.Orange, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1961"), Price=27000, Type= CarType.Clasic },
            new ClasicCar{Name="Cadillac", Antique=true, Capacity= 2, Color=CarColor.Brown, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1979"), Price=11000, Type= CarType.Clasic },
            new ClasicCar{Name="Aston Martin", Antique=true, Capacity= 4, Color=CarColor.Yellow, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1962"), Price=30000, Type= CarType.Clasic },
            new ClasicCar{Name="Alfa Romeo", Antique=true, Capacity= 2, Color=CarColor.Brown, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1969"), Price=18000, Type= CarType.Clasic },
            new ClasicCar{Name="Porsche", Antique=true, Capacity= 2, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1953"), Price=15000, Type= CarType.Clasic },
            new ClasicCar{Name="Ferrari", Antique=true, Capacity= 4, Color=CarColor.Pink, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1978"), Price=12000, Type= CarType.Clasic },
            new ClasicCar{Name="Mini", Antique=true, Capacity= 4, Color=CarColor.White, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("1949"), Price=40000, Type= CarType.Clasic }
        };
        List<HatchBagCar> hatchbagCarList = new List<HatchBagCar>()
        {
            new HatchBagCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Sunroof=true},
            new HatchBagCar{Name="Ford", Capacity= 6, Color=CarColor.Brown, FuelType=FuelType.Diesel, ModelYear=DateTime.Parse("2017"), Price=13000, Type= CarType.HatchBag, Sunroof=false},
            new HatchBagCar{Name="Mercedes", Capacity= 5, Color=CarColor.Orange, FuelType=FuelType.Hybrid, ModelYear=DateTime.Parse("2001"), Price=12000, Type= CarType.HatchBag, Sunroof=true},
            new HatchBagCar{Name="Nissan", Capacity= 4, Color=CarColor.White, FuelType=FuelType.Electric, ModelYear=DateTime.Parse("2005"), Price=21000, Type= CarType.HatchBag, Sunroof=false},
            new HatchBagCar{Name="Kia", Capacity= 8, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2019"), Price=6000, Type= CarType.HatchBag, Sunroof=true},
            new HatchBagCar{Name="Seat", Capacity= 7, Color=CarColor.Yellow, FuelType=FuelType.Electric, ModelYear=DateTime.Parse("2015"), Price=4000, Type= CarType.HatchBag, Sunroof=false},
            new HatchBagCar{Name="Skoda", Capacity= 5, Color=CarColor.Green, FuelType=FuelType.Hybrid, ModelYear=DateTime.Parse("2022"), Price=17000, Type= CarType.HatchBag, Sunroof=false},
            new HatchBagCar{Name="Wolkswagen", Capacity= 4, Color=CarColor.Purple, FuelType=FuelType.Diesel, ModelYear=DateTime.Parse("2020"), Price=12500, Type= CarType.HatchBag, Sunroof=true},
            new HatchBagCar{Name="Volvo", Capacity= 6, Color=CarColor.Red, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2021"), Price=7200, Type= CarType.HatchBag, Sunroof=true},
            new HatchBagCar{Name="Toyota", Capacity= 10, Color=CarColor.Yellow, FuelType=FuelType.Diesel, ModelYear=DateTime.Parse("2012"), Price=5120, Type= CarType.HatchBag, Sunroof=false}
        };
        List<RoadCar> roadCarList = new List<RoadCar>()
        {
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
            new RoadCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Machine = 2 },
        };
        List<SedanCar> sedanCarList = new List<SedanCar>()
        {
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"},
            new SedanCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Tire="Winter"}
        };
        List<SportCar> sportCarList = new List<SportCar>()
        {
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"},
            new SportCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, TurboName="Nitro"}
        };
        List<SUVCar> suvCarList = new List<SUVCar>()
        {
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},
            new SUVCar{Name="BMW", Capacity= 4, Color=CarColor.Black, FuelType=FuelType.Gas, ModelYear=DateTime.Parse("2003"), Price=8000, Type= CarType.HatchBag, Headlamps=200},

        };

       public void AllCarList()
        {
            List<object> allCarList = new List<object>();
            allCarList.Add(suvCarList);
            allCarList.Add(sportCarList);
            allCarList.Add(sedanCarList);
            allCarList.Add(roadCarList);
            allCarList.Add(clasicCarList);
            allCarList.Add(hatchbagCarList);
        }
        
        
       

    }
}
