# Perceptron neural network
import numpy as np

# Normalization function for converting guesses to 1/0
def sigmoid(x):
    return 1 / (1 + np.exp(-x))

def sigmoid_derivative(x):
    return x * (1 - x)

# Initial dataset (3x4 matrix)
training_inputs = np.array([[0, 0, 1],
                            [1, 1, 1],
                            [1, 0, 1],
                            [0, 1, 1]])
training_outputs = np.array([[0, 1, 1, 0]]).T

# Testing, comment out for real example
np.random.seed(1)

# Weight values
synaptic_weights = 2 * np.random.random((3, 1)) - 1
print("Random starting synaptic weights: ")
print(synaptic_weights)

# Main loop
for i in range(100000):
    input_layer = training_inputs
    outputs = sigmoid(np.dot(input_layer, synaptic_weights))  # Multiplies input by weights to get output
    error = training_outputs - outputs
    adjustments = error * sigmoid_derivative(outputs)
    synaptic_weights += np.dot(input_layer.T, adjustments)

# Output result after training
print("Synaptic weights after training: \n", synaptic_weights)
print("Outputs: \n", outputs)
