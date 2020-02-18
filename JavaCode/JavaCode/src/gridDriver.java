import java.util.ArrayList;

public class gridDriver {

	public static void main(String[] args) {
		Grid<Integer> newGrid = new Grid<Integer>(5, 5);
		ArrayList<Integer> collection = new ArrayList<Integer>();
		collection.add(0);
		collection.add(1);
		collection.add(2);
		collection.add(3);
		
		for (int i = 0; i < newGrid.getStartYSize(); i++) {
			for (int j = 0; j < newGrid.getStartXSize(); j++) {
				newGrid.set(j, i, j);
			}
		}
		
		System.out.println(newGrid.toString());
		Grid<Integer> clone = (Grid<Integer>) newGrid.clone();
		System.out.println(clone.toString());
		
		//System.out.println(newGrid.getStartXSize() + ", " + newGrid.getStartYSize());
		//System.out.println(newGrid.size());
	}
}