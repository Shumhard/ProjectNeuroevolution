using NeuralNetwork.Core.Layers;
using NeuralNetwork.Core.Neurons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Core.Implementations.Layers
{
    internal class NeuralLayer : ILayer
    {
        private List<INeuron> _neurons;

        public NeuralLayer()
        {
            _neurons = new List<INeuron>();
        }

        public List<INeuron> Neurons => this._neurons;

        /// <summary>
        /// Connecting two layers.
        /// </summary>
        public void ConnectLayers(ILayer layer)
        {
            var combos = Neurons.SelectMany(neuron => layer.Neurons, (neuron, input) => new { neuron, input });
            combos.ToList().ForEach(x => x.neuron.AddInputNeuron(x.input));
        }
    }
}
