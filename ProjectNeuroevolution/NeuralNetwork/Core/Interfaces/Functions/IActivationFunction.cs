using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Functions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IActivationFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        double CalculateOutput(double input);
    }
}
