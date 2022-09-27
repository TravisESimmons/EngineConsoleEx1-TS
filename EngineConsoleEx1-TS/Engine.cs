﻿using System;
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

//![Engine] (./ CP - 7002 - TStevens.jpg)
    public class Engine
    {
        private int HP; 
        private string Model;
        private string SerialNumber; 
        private int Weight; 
    }

    public Engine (int, HP, string Model, string SerialNumber, int Weight)
        {


        }
    public int HP
        {
            get { return _HP; }
            private set
            {
                if ( _HP => 0)
                {
                    throw new ArgumentOutOfRangeException("HP must be greather than 0..");
                }
                _HP = value;
            }
        }

     public string Model
        {
            get { return _Model; }
            private set
            {
                if (XXXXXX.IsEmpty(value))
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
                if (XXXXXX.IsEmpty(value))
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
                if (.IsEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Weight must be greater than 0..")
                }
                _Weight = value;
        }
    }

    public override string ToString()
      {
           
          return $"{},{},{}";
      }
}
