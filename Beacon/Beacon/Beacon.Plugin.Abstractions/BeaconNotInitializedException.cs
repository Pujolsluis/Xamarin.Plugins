﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beacon.Plugin.Abstractions
{
    public class BeaconNotInitializedException : Exception
    {
          public BeaconNotInitializedException()
          {

          }

          public BeaconNotInitializedException(string message) : base(message)
          {

          }
    }

}
