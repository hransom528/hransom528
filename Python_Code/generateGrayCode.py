# Harris Ransom
# Gray Code Generator
# 7/20/24

# Imports
import argparse

# Generates an n-bit Gray code sequence
# TODO: Attempt to optimize this function with threads for large n
def generate_gray_code(n):
    # Generate gray code sequence for n bits
    gray_code = []
    for i in range(2**n):
        val = i ^ (i >> 1)
        binString = bin(val)[2:]
        gray_code.append(binString.zfill(n))
    return gray_code

# MAIN
def main():
    # Get command line input
    parser = argparse.ArgumentParser(description="Generate Gray Code")
    parser.add_argument("n", type=int, help="Number of bits")
    parser.add_argument("-t", "--table", action="store_true", help="Print as table")
    args = parser.parse_args()
    n = args.n

    # Check n
    if (n < 1):
        print("Error: n must be greater than 0")
        return
    if (n > 15):
        print("Warning: n is greater than 15, this may take a while to compute")

    # Generate Gray code
    gray_code = generate_gray_code(n)

    # Print Gray code
    if (args.table):
        # Print as table
        print("Gray Code Table")
        print("---------------")
        print(f"{'Decimal':<10}{'Binary':<16}{'Gray Code':<16}")
        for i in range(len(gray_code)):
            print(f"{i:<10}{bin(i)[2:].zfill(n):<16}{gray_code[i]:<16}")
    else:
        print(gray_code)

# Dunder main
if __name__ == "__main__":
    main()

