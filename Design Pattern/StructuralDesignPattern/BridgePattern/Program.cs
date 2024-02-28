using BridgePattern;

IFuelType petrol = new Petrol();
Car car = new Car(petrol);
car.Drive();
car.FuelUsed();