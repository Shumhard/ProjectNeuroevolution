using NeuralNetwork.Core.Connections;
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
    public class WeightedSumFunction : IInputFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public double CalculateInput(List<ISynapse> inputs)
        {
            return inputs.Select(x => x.Weight * x.GetOutput()).Sum();
        }
    }
}
