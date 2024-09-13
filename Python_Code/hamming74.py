# Harris Ransom
# Hamming Code Calculations
# 9/13/2024

# Import Statements
import numpy as np

# Define relevant matrices
G = np.array([[1, 1, 1, 0, 0, 0, 0],
			  [1, 0, 0, 1, 1, 0, 0],
			  [0, 1, 0, 1, 0, 1, 0],
			  [1, 1, 0, 1, 0, 0, 1]]) # Generator matrix

H = np.array([[1, 0, 1, 0, 1, 0, 1],
			  [0, 1, 1, 0, 0, 1, 1],
			  [0, 0, 0, 1, 1, 1, 1]]) # Parity Check matrix

# Encodes 4-bit data with Hamming (7, 4) code
def encode(data):
	# Check data size
	dataShape = data.shape
	if (data.size != 4):
		raise ValueError("Data must be 4 bits long")
	if (dataShape == (4,)): # Row vector
		data = data.reshape(4, 1)

	# Encode data
	x = G.T @ data
	x = x % 2
	return x

# Performs Hamming (7,4) parity check on 7-bit data
def parityCheck(data):
	# Check data size
	dataShape = data.shape
	if (data.size != 7):
		raise ValueError("Data must be 7 bits long")
	if (dataShape == (7,)): # Row vector
		data = data.reshape(7, 1)

	# Check data
	syndrome = H @ data
	syndrome = syndrome % 2
	return syndrome

# MAIN
if __name__ == "__main__":
	# TODO: Get input

	# Test encode function
	data = np.array([[1], [0], [1], [1]])
	print(f"Original 4-bit string: {data.tolist()}")
	x = encode(data)
	print(f"Encoded 7-bit string: {x.tolist()}")

	# Test parity check function
	z = parityCheck(x)
	print(f"Syndrome vector: {z.tolist()}")