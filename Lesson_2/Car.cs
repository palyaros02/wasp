using System;

// private - доступен только внутри класса, по-умолчанию
// public - доступен везде
// protected - доступен внутри класса и внутри классов-наследников
// internal - доступен внутри сборки

namespace ConsoleApp
{
    class Car
    {
        private string _name;
        private string _color;
        private int _numberOfWheels;

        //пажилой дебилизм
        /*public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }*/

        //свойства
        public string Name
        {
            get 
            { 
                return _name/* + "_car"*/; 
            }
            /*private*/ set //(string value)
            {
                _name = value/* + "_123"*/;
            } 
        }

        public string Color { get => _color; set => _color = value; }
        public int NumberOfWheels { get => _numberOfWheels; set => _numberOfWheels = value; }

        public Car(string color, string name, int wheels) // конструктор
        {
            _name = name;
            _color = color;
            _numberOfWheels = wheels;

            Console.WriteLine("Car created");
        }
        public Car() // конструктор
        {
            _name = "Default";
            _color = "Default";
            _numberOfWheels = 4;

            Console.WriteLine("Default car created");
        }
        
        public Car(string color) : this()
        {
             _color = color;
            Console.WriteLine("Car with color created");
        }

        //автоматические свойства
        //public string Name { get; set; } = "Default";

        public void Move()
        {
            Console.WriteLine($" > {_name} is moving");
        }

        public int GetNumberOfWheels()
        {
            return _numberOfWheels;
        }

        public override string ToString()
        {
            return $"Car: {_name}, color: {_color}, wheels: {_numberOfWheels}";
        }


    }
}
