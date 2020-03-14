public class tableDriver {
	public static void main(String[] args) {
		Table<Integer> table = new Table<Integer>(2, 2, Integer.class);

		for (int i = 0; i < table.getTable().length; i++) {
			for (int j = 0; j < table.getTable()[0].length; j++) {
				table.set(j, i, j);
			}
		}
		
		Integer[][] ints = { 
				{1, 2},
				{1, 2},
				{1, 2}
		};
		Table<Integer> newTable = new Table<Integer>(ints[0].length, ints.length, ints.getClass());
		newTable = Table.toTable(ints);
		
		//System.out.println(table.toString());
		System.out.println(newTable.toString());
	}
}