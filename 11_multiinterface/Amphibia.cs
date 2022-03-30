using System;

interface ICar {
    void StartEngine();
}

interface IBoat {
    void StartEngine();
}

public class Amphibia : ICar, IBoat
{
    public void StartEngine() {
        Console.WriteLine("asdf-all");
    }

    void ICar.StartEngine() {
        Console.WriteLine("asdf-only-car");
    }
    void IBoat.StartEngine() {
        Console.WriteLine("asdf-only-boat");
    }
}
