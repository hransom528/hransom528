import java.util.ArrayList;

public class gridDriver {

	public static void main(String[] args) {
		Grid<Integer> newGrid = new Grid<Integer>(2, 2);
		ArrayList<Integer> collection = new ArrayList<Integer>();
		collection.add(0);
		collection.add(1);
		
		for (int i = 0; i < newGrid.getStartYSize(); i++) {
			for (int j = 0; j < newGrid.getStartXSize(); j++) {
				newGrid.setVal(j, i, j);
			}
		}
		
		System.out.println(newGrid.isEmpty());
		System.out.println(newGrid.toString());
		System.out.println(newGrid.getStartXSize() + ", " + newGrid.getStartYSize());
		System.out.println(newGrid.size());
		
		
	}
}