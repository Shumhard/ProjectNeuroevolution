using NeuralNetwork.Core.Neurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Layers
{
    public interface ILayer
    {
        List<INeuron> Neurons { get; }

        void ConnectLayers(ILayer layer);
    }
}
