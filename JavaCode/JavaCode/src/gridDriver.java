import java.util.ArrayList;

public class gridDriver {

	public static void main(String[] args) {
		Grid<Integer> newGrid = new Grid<Integer>(10, 10);
		newGrid.setValAtCoord(0, 0, 3);
		System.out.println(newGrid.getString());
	}

}
