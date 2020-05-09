public class longestStreakPractice {
	public static void main(String[] args) {
		longestStreak("CCAAAAAATTT!");
	}

	public static void longestStreak(String str) {
		String longest = "";
		String tempString = "";
		tempString += str.charAt(0);
		for (int j=0; j < str.length() - 1; j++) {
			if (str.charAt(j) == str.charAt(j + 1)) {
				tempString += str.charAt(j+1);
			}
			else {
				tempString = "";
				tempString += str.charAt(j+1);
			}	
			if (tempString.length() > longest.length()) {
				longest = tempString;
			}
		}
		System.out.println(longest);
	}
}