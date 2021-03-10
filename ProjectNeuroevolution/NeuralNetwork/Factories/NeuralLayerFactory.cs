﻿using NeuralNetwork.Core.Functions;
using NeuralNetwork.Core.Implementations.Layers;
using NeuralNetwork.Core.Implementations.Neurons;
using NeuralNetwork.Core.Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Factories
{
    public static class NeuralLayerFactory
    {
        public static ILayer CreateNeuralLayer(int numberOfNeurons, IActivationFunction activationFunction, IInputFunction inputFunction)
        {
            var layer = new NeuralLayer();

            for (int i = 0; i < numberOfNeurons; i++)
            {
                var neuron = new Neuron(activationFunction, inputFunction);
                layer.Neurons.Add(neuron);
            }

            return layer;
        }
    }
}
