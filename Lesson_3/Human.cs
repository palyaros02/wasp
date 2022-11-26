using System;
namespace WaspTutorial
{
    public class Human
    {
        protected int
            _iq,
            _age,
            _height,
            _weight;

        string FavCar { get; set; }


        public virtual int Age // virtual - позволяет переопределить метод в наследнике
        {
            get => _age;
            set
            {
                if (value > 0)
                    _age = value;
            }
        }
        public Human(int age, int iq, int height, int weight)
        {
            _age = age;
            _iq = iq;
            _height = height;
            _weight = weight;
            FavCar = "Lada";
        }
        public Human(int age)
        {
            _age = age;
        }
        public override string ToString()
        {
            return $"Age: {_age}, IQ: {_iq}, Height: {_height}, Weight: {_weight}, FavCar: {FavCar}";
        }

    }
    public class Child : Human
    {
        public Child(int age, int iq, int height, int weight) : base(age, iq, height, weight)
        { }
        public bool IsTeenage
        {
            get => _age > 11 && _age < 18;
        }
        public override int Age
        {
            //get => _age; // вызывается метод из родительского класса
            set
            {
                if (value > 0 && value < 19)
                    _age = value;
               else
                    Console.WriteLine("Age must be between 0 and 19");
            }
        }
    }

    public class Oldman : Human
    {
        public Oldman(int age, int iq, int height, int weight) 
            : base(age, iq, height, weight) { }
        public override int Age
        {
            set
            {
                if (value > 65)
                    _age = value;
                else
                    Console.WriteLine("Age must be greater than 65");
            }
        }
        public int Pension (int rubles)
        {
            return (Age/100) * rubles;
        }
    }
}