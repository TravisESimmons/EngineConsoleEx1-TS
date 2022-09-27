using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml;

namespace EngineConsoleEx1_TS
{ // ### The `RailCar`

//Railcars carry various kinds of goods.Each railcar is stenciled with certain information:

//- **Serial Number** (e.g.: "18172") - Uniquely identifies a specific car; may include characters and digits in the number.
//- **Light Weight** (in pounds) - The weight of the railcar when empty.
//- ** Capacity** (in pounds) - Standard maximum Net Weight.This is the "ballpark" figure used when loading a railcar. The actual scale weight may be slightly higher or lower for what is considered a "full" load.
//- **Load Limit** (in pounds) - Absolute maximum Net Weight allowed for safety purposes.This does not include the Light Weight. Exceeding this weight makes the railcar unsafe.

//Each railcar is designed to carry a  specific type of cargo and is tracked as to being in service or out of service:

//- ** Type** - Value that represents the type of this car.
//- **InService** - Value that represents the activity status of this car.
//![RailCar] (./Hopper.jpg)

//Railcars can be loaded with freight. When loaded, each car is weighed at a scale that gives the weight to the nearest 100 pounds. The **Gross Weight** is the weight of the freight and the railcar. The **Net Weight** is the weight of the freight only. Any weight within 90% of the **Capacity** is considered as a "full load". 

//All fields must be stored as read-only information (it cannot be modified). Use private fields and properties with private sets.InService can be altered via the property.You will need a greedy constructor for this class.Create an overloaded.ToString() method for the class to display all the instance values in a comma separated value string.

//![RailCar] (./RailCar-ClassDiagram.png)

//Note the following:

//- Load Limit and Capacity are in terms of the freight itself.This is the net weight of the railcar, and does not include the Light Weight.
//- Capacity is always less than the Load Limit.
//- When recording scale weights, the** gross weight** is given; this is the actual weight of the RailCar with its load.This value must be between the Light Weight and the *gross* Load Limit (`LoadLimit + LightWeight`). Anything outside of these values should throw an exception. If the gross weight supplied is less than the Light Weight, then your error message should begin with the phrase "Scale Error -". If the weight is over the safe limit (`LoadLimit + LightWeight`), the error message should begin with "Unsafe Load -".

//> "For safety, a rail car should be loaded so that Gross Weight is less than the sum of its stenciled Load Limit + Light Weight."
//> 
//> [Source: Boulder Creek Engineering](https://www.bouldercreekengineering.com/scale_ops3.php)
    internal class RailCar
    {
    }
}
