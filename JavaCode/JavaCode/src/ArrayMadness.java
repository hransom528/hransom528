public class ArrayMadness {
   public static int findMax(int [] numbersArray) {
	   int max = numbersArray[0];
	   for (int item : numbersArray) {
		   if (item > max) {
			   max = item;
		   }
	   }
	   return max;
   }

   public static int findMin(int [] numbersArray) {
	   int min = numbersArray[0];
	   for (int item : numbersArray) {
		   if (item < min) {
			   min = item;
		   }
	   }
	   return min;
   }

   public static int totalMaxMin(int [] numbersArray) {
      int max = findMax(numbersArray);
      int min = findMin(numbersArray);
      return max + min;
   }
  
   public static void main(String[] args) {
      int [] testValues = {6, 20, 31, 2, 7, 14};
                
      if (findMax(testValues) == 31) {
         System.out.println("Part A is correct.");
      }
      else {
         System.out.println("Part A is incorrect.");
      }
      
      if (findMin(testValues) == 2) {
         System.out.println("Part B is correct.");
      }
      else {
         System.out.println("Part B is incorrect.");
      }      
      
      if (totalMaxMin(testValues) == 33) {
         System.out.println("Part C is correct.");
      }
      else {
         System.out.println("Part C is incorrect.");
      }         
   }
}
