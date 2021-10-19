using System;

namespace cSharp_fundamentals {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            
            Dog dog = new Dog(4);
            Rabbit bunny = new Rabbit();
            dog.makeNoise();
            bunny.makeNoise();
            // Abstraction: Dog doesn't know the internal workings of how get id works it just uses it.
            Console.WriteLine(dog.GetId());
        }

    }
}

// Abstraction example too
public abstract class Animal {
    // Encapsulation: not exposing variables with accessor method getId
    private int id = 0;
    private int _numberOfFeet;
    
    public Animal (int numberOfFeet) {
        _numberOfFeet = numberOfFeet;
    }

    public int GetId() {
        return this.id;
    }

    public void SetId(int id) {
        this.id = id + 1;
    }

    public void makeNoise(){
        Console.WriteLine("agghhhhh!");
    }

}

//  Inheritance: Dog can reuse the code of Animal super class. 
public class Dog : Animal {

    public Dog (int numberOfFeet): base(numberOfFeet){}

    // Polymorphism: overriding makeNoise() class method.
    public void makeNoise(){
        Console.WriteLine("woooof!");
    }

}

public class Rabbit : Animal {
    public void makeNoise(){
        // base.makeNoise();
        Console.WriteLine("rabbitNoise!");
    }
}