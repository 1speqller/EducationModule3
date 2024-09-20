abstract class CarEngine { }

class ElectricEngine : CarEngine { }

class GasEngine : CarEngine { }

abstract class CarPart { }

class Battery : CarPart { }

class Differential : CarPart { }

class Wheel : CarPart { }

class Car<TEngine> where TEngine : CarEngine
{
    public TEngine Engine;

    public virtual void ChangePart<TCarPart>(TCarPart newPart) where TCarPart : CarPart
    {

    }
}