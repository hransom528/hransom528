import java.util.Scanner;

public class ResistorColorCodeCalc {
    // Gets and checks input for all band colors
    public static int getBandColor(int band, int bandNum, Scanner scnr) {
        int input = -5;    

        if (band == bandNum - 1) {  // Multiplier
            System.out.println("Resistor multiplier color codes: ");
            System.out.println("0  - Black");
            System.out.println("1  - Brown");
            System.out.println("2  - Red");
            System.out.println("3  - Orange");
            System.out.println("4  - Yellow");
            System.out.println("5  - Green");
            System.out.println("6  - Blue");
            System.out.println("7  - Violet");
            System.out.println("8  - Grey");
            System.out.println("9  - White");
            System.out.println("-1 - Gold");
            System.out.println("-2 - Silver");
            System.out.println("-3 - Pink");

            System.out.println("What is the numeric code for the color of the multiplier band? ");
            input = scnr.nextInt();

            while (input < -3 || input > 9) {
                System.out.println("Please input a valid numeric code for the color of the multiplier band: ");
                input = scnr.nextInt();
            }
        }
        else if (band == bandNum) { // Tolerance
            System.out.println("Resistor tolerance color codes: ");
            System.out.println("5  - Gold");
            System.out.println("10 - Silver");

            System.out.println("What is the numeric code for the color of the tolerance band? ");
            input = scnr.nextInt();

            while (input != 5 && input != 10) {
                System.out.println("Please input a valid numeric code for the color of the tolerance band: ");
                input = scnr.nextInt();
            }
        }
        else if (band != bandNum) { // Values
            System.out.println("Resistor value color codes: ");
            System.out.println("0 - Black");
            System.out.println("1 - Brown");
            System.out.println("2 - Red");
            System.out.println("3 - Orange");
            System.out.println("4 - Yellow");
            System.out.println("5 - Green");
            System.out.println("6 - Blue");
            System.out.println("7 - Violet");
            System.out.println("8 - Grey");
            System.out.println("9 - White");

            System.out.println("What is the numeric code for the color of band " + band + "? ");
            input = scnr.nextInt();

            while (input < 0 || input > 9) {
                System.out.println("Please input a valid numeric code for the color of band " + band + ": ");
                input = scnr.nextInt();
            }
        }
        if (input != -5) return input;
    }

    // Processes values for given bands and calculates final resistance values
    public static double[] processBands(int[] bands, int bandNum) {
        double finalVal = -1;
        double minVal = -1;
        double maxVal = -1;

        // Parse multiplier
        double multiplier = Math.pow(10, (bands[bandNum - 2]));

        // Parse tolerance
        double tolerance = bands[bandNum - 1];
        if (tolerance == 5) tolerance = 0.05;
        else if (tolerance == 10) tolerance = 0.10;

        // Parse values
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < bands.length - 2; i++) {
            sb.append(bands[i]);
        }
        double initialVal = Double.parseDouble(sb.toString());

        // Calculates final resistance values
        finalVal = initialVal * multiplier;
        minVal = finalVal * (1 - tolerance);
        maxVal = finalVal * (1 + tolerance);

        // Returns values
        double[] returnVals = new double[4];
        returnVals[0] = finalVal;
        returnVals[1] = minVal;
        returnVals[2] = maxVal;
        returnVals[3] = tolerance * 100;
        return returnVals;
    }
    
    public static void main(String[] args) {
        Scanner scnr = new Scanner(System.in);
        int bandNum = 0;

        // Gets number of resistor bands
        System.out.print("Is the resistor 4 bands or 5 bands? ");
        bandNum = scnr.nextInt();
        while ((bandNum != 4) && (bandNum != 5)) {
            System.out.print("Please input a valid band number: ");
            bandNum = scnr.nextInt();
        }

        // Gets individual bands
        int[] bands = new int[bandNum];
        for (int i = 1; i <= bandNum; i++) {
            bands[i - 1] = getBandColor(i, bandNum, scnr);
        }

        // Processes bands
        double[] finalVals = processBands(bands, bandNum);

        // Outputs final results
        System.out.print("\n");
        System.out.println("Resistance value: " + finalVals[0] + "ohms +- " + (int) finalVals[3] + "%");
        System.out.println("Minimum resistance value: " + finalVals[1] + "ohms");
        System.out.println("Maximum resistance value: " + finalVals[2] + "ohms");
    }
}