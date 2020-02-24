import java.util.ArrayList;
import java.util.List;

public class tableDriver {
	public static void main(String[] args) {
		Table<Integer> table = new Table<Integer>(2, 2, Integer.class);
		
		for (int i = 0; i < table.getTable().length; i++) {
			for (int j = 0; j < table.getTable()[0].length; j++) {
				table.set(j, i, j);
			}
		}
		
		List<Integer> test = new ArrayList<Integer>();
		for (int i = 0; i < 4; i++) {
			test.add(i);
		}
		Table<Integer> newTable = table.toTable(2, 2, test);
		System.out.println(table.toString());
		System.out.println(newTable.toString());
	}
}