﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsiParsi
{
  internal class Delegates
  {
    public delegate void VoidDelegate();
    public delegate void StringDelegate(string value);
    public delegate void ExceptionStringDelegate(Exception ex, string value);
    public delegate void RCMessageDelegate(RCMessage message);
  }
}
