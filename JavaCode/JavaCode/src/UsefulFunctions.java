import java.util.Scanner;

public class UsefulFunctions {
	//Gets smallest integer in an integer array
	public static int getMinimumInt(int[] listInts, int listSize) {
		int min = listInts[0];
		for (int i = 1; i < listSize; i++) {
			if (listInts[i] < min) {
				min = listInts[i];
			}
		}
		return min;
	}

	//Method that returns greatest common divisor of two inputs
	public static int findGCD(int aVal, int bVal) {
		int numA;
		int numB;

		numA = aVal;
		numB = bVal;

		while (numA != numB) { // Euclid's algorithm
			if (numB > numA) {
				numB = numB - numA;
			} else {
				numA = numA - numB;
			}
		}

		return numA;
	}

	//Method that returns least common multiple of two inputs
	public static int findLCM(int aVal, int bVal) {
		int lcmVal;

		lcmVal = Math.abs(aVal * bVal) / findGCD(aVal, bVal);

		return lcmVal;
	}

	//Converts a height in feet/inches to centimeters
	public static double heightFtInToCm(int heightFt, int heightIn) {
		final double CM_PER_IN = 2.54;
		final int IN_PER_FT = 12;
		int totIn;
		double cmVal;

		totIn = (heightFt * IN_PER_FT) + heightIn; // Total inches
		cmVal = totIn * CM_PER_IN;                 // Conv inch to cm
		return cmVal;
	}

	//Finds greater of two doubles
	public static double findMax(double num1, double num2) {
		double maxVal;

		if (num1 > num2) {  // if num1 is greater than num2,
			maxVal = num1;  // then num1 is the maxVal.
		}
		else {              // Otherwise,
			maxVal = num2;  // num2 is the maxVal.
		}

		return maxVal;
	}

	//Calculates the volume of a pyramid
	public static double pyramidVolume(double baseLength, double baseWidth, double pyramidHeight) {
		double baseArea = baseLength * baseWidth;
		return (baseArea * pyramidHeight * (1 / 3.0));
	}

	//MAIN
	public static void main(String[] args) {
		Scanner scnr = new Scanner(System.in);
		scnr.close();
	}
}
