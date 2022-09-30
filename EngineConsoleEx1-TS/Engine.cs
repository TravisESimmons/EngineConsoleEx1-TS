using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineConsoleEx1_TS
{ // ### The `Engine`

    //    Engines are the workhorse of the railway system.For our purposes, we need to track the train engine's **Model** (e.g.: "CP 8002"), **Serial Number** (e.g.: "48807"), **Weight** (in pounds, e.g.: 147,700), and **Horse Power** (e.g.: 4400). 
    //    All of this must be stored as read-only information (it cannot be modified). Use private fields and properties with private sets.You will need a greedy constructor for this class. Create an overloaded.ToString() method for the class to display all the instance values in a comma separated value string.

    //Note the following:
    //-Horse Power must be a positive whole number between 3500 and 5500. HP is measured in 100 HP increments.

    public class Engine
    {
        private int _HP;
        private string _Model;
        private string _SerialNumber;
        private int _Weight;

        public Engine(int hp, string model, string serialNumber, int weight)
        {
            HP = hp;
            Model = model;
            SerialNumber = serialNumber;
            Weight = weight;
        }

        public int HP
        {
            get { return _HP; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("HP must be greater than 0. Can not be a negative integer.");
                }

                if (value % 100 != 0)
                {
                    throw new ArgumentOutOfRangeException("HP must be in increments of 100..");
                }

                if (value <= 3500 || value >= 5500)
                {
                    throw new ArgumentOutOfRangeException("HP must be between 3500 and 5000");
                }
                _HP = value;
            }
        }
        
        public string Model
        {
            get { return _Model; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model is required.");
                }
                _Model = value;
            }
        }

        public string SerialNumber
        {
            get { return _SerialNumber; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("SerialNumber is required.");
                }
                _SerialNumber = value;
            }
        }

        public int Weight
        {
            get { return _Weight; }
            private set
            {
                if (value <= 0)
                // and if not in increments of 100, ie %100 *******
                {
                    throw new ArgumentOutOfRangeException("Weight must be greater than 0..");
                }

                if (value % 100 != 0)
                {
                    throw new ArgumentOutOfRangeException("Weight must be in increments of 100..");
                }
                _Weight = value;
            }
        }

        public override string ToString()
        {

            return $"{SerialNumber},{Model},{HP},{Weight}";
        }
    }
}
