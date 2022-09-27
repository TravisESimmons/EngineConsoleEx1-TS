﻿using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineConsoleEx1_TS
{
//### The `Train`

//    A train is a set of railcars pulled by an engine.At present, a train must have at least a single engine (this may change in the future). Railcars are added to the train one-by-one.All `set` properties must be `private`, while all getters are public; some properties only have a getter, because they calculate their values based on the state of the train.

//- ** Gross Weight** - This is the total weight of the train, including the engine.
//- **Maximum Gross Weight** - This is based upon the capacity of the engine.The "rule-of-thumb" that we will be following is that 1 HP can pull 1 Ton (a Ton is 2000 pounds). Thus, a 4400 HP engine can pull about 4400 Tons.

//![Train] (./Train-ClassDiagram.png)

//Note the following:

//- When adding railcars to the train, do not allow the gross weight to exceed the maximum gross weight allowed for the train.
    internal class Train
    {
    }
}
