class ElectricEngine { }

class GasEngine { }

class Battery { }

class Differential { }

class Wheel { }

class Car<T>
{
    public T Engine;

    public virtual void ChangePart<T2>(T2 newPart)
    {

    }
}