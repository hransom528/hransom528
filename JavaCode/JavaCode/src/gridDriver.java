
public class gridDriver {

	public static void main(String[] args) {
		Grid<Integer> newGrid = new Grid<Integer>(4, 3);
		
		for (int i = 0; i < newGrid.getySize(); i++) {
			for (int j = 0; j < newGrid.getxSize(); j++) {
				newGrid.setVal(j, i, j);
			}
		}
		
		System.out.println(newGrid.getString());
		System.out.println(newGrid.getxSize() + ", " + newGrid.getySize());
	}
}