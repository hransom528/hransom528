public class tableDriver {
	public static void main(String[] args) {
		Table<Integer> table = new Table<Integer>(3, 4, Integer.class);
		
		for (int i = 0; i < table.getTable().length; i++) {
			for (int j = 0; j < table.getTable()[0].length; j++) {
				table.set(j, i, j);
			}
		}
		
		Table<Integer> clone = new Table<Integer>(3, 4, Integer.class);
		clone = table.clone();
		System.out.println(clone.toString());
		System.out.println(table.toString());
	}
}