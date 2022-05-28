using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface _Interface
{
   
}
public interface IVehicle
{
    void go();

    void stop();
}

public interface IRideable
{
    void Ride();
}

public interface IFlyable
{
    void Soar();
}

public abstract class BaseVehicle: IVehicle
{
    public void go()
    {
        Console.WriteLine("Vehicle is going...");
    }

    public void stop()
    {
        Console.WriteLine("Vehicle has stopped...");
    }
}
public class Car : BaseVehicle
{
   
}
public class Bike : BaseVehicle,IRideable
{
    public void Ride()
    {
        throw new System.NotImplementedException();
    }

}
public class Plane : BaseVehicle,IFlyable
{

    public void Soar()
    {
        throw new System.NotImplementedException();
    }

    
}