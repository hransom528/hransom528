import java.lang.Math;
import java.util.Scanner;

//Quadratic Formula class
public class quadraticFormula {

	//Calculations for the + operation in the +-
	public static double calcPositive(double a, double b, double c) {
		double result = 0;
		double squareRoot = 0;
		
		squareRoot = Math.sqrt(Math.pow(b, 2) - (4*a*c));
		
		result = ((-1 * b) + squareRoot) / (2 * a);
		return result;
	}
	
	//Calculations for the - operation in the +-
	public static double calcNegative(double a, double b, double c) {
		double result = 0;
		double squareRoot = 0;
		
		squareRoot = Math.sqrt(Math.pow(b, 2) - (4*a*c));
		
		result = ((-1 * b) - squareRoot) / (2 * a);
		return result;
	}
	
	//MAIN
	public static void main(String[] args) {
		Scanner scanObj = new Scanner(System.in); // Initializes the scanner class
		double a; //Declares A coefficient
		double b; //Declares B coefficient
		double c; //Declares C constant
		
		//Gets A, B, and C values
		System.out.println("Enter your A, B, and C values as doubles: "); 
			//Gets A value
		System.out.println("A value:");
		a = scanObj.nextDouble();
			//Gets B value
		System.out.println("B value:\n");
		b = scanObj.nextDouble();
			//Gets C value
		System.out.println("C value:\n");
		c = scanObj.nextDouble();
		
		//Calculates and displays results
		double positive = calcPositive(a,b,c); //Calculates the plus operation
		double negative = calcNegative(a,b,c); //Calculates the minus operation
		System.out.println(positive + ", " + negative); //Displays results
		
		System.out.println("Enter E to exit.\n");
		if ((scanObj.nextLine()) == "e"){
			scanObj.close();
			System.exit(0);
		}
		else if (((scanObj.nextLine()) == "E")) {
			scanObj.close();
			System.exit(0);
		}
	}

}