﻿using NeuralNetwork.Core.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Functions
{
    public interface IInputFunction
    {
        double CalculateInput(List<ISynapse> inputs);
    }
}
