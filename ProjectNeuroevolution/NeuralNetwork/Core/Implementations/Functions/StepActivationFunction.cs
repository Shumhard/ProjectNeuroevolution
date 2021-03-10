using NeuralNetwork.Core.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Implementations.Functions
{
    /// <summary>
    /// 
    /// </summary>
    public class StepActivationFunction : IActivationFunction
    {
        private double _treshold;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="treshold"></param>
        public StepActivationFunction(double treshold)
        {
            _treshold = treshold;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double CalculateOutput(double input)
        {
            return Convert.ToDouble(input > _treshold);
        }
    }
}
