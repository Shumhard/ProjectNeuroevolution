using NeuralNetwork.Core.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Implementations.Functions
{
    internal class RectifiedActivationFuncion : IActivationFunction
    {
        public double CalculateOutput(double input)
        {
            return Math.Max(0, input);
        }
    }
}
