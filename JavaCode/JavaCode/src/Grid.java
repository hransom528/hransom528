import java.util.ArrayList;
import java.util.Iterator;

/**
 * @author Harris Ransom
 * @param <T>
 */
public class Grid<T> implements Iterable<T>{
	private int xSize;
	private int ySize;
	private ArrayList<ArrayList<T>> grid;

	/**Grid Constructor
	 * @param xSize
	 * @param ySize
	 */
	public Grid (int xSize, int ySize) {
		this.xSize = xSize;
		this.ySize = ySize;
		this.grid = new ArrayList<ArrayList<T>>();

		//Fills grid with rows
		for (int i = 0; i < ySize; i++) {
			grid.add(new ArrayList<T>());
		}

		//Fills grid with default objects
		for (ArrayList<T> subArray : grid) {
			for (int i = 0; i < this.xSize; i++) {
				subArray.add((T) new Object());
			}
		}
	}

	/**Returns array row size
	 * @return
	 */
	public int getxSize() {
		return this.xSize;
	}

	/**Returns array col size
	 * @return
	 */
	public int getySize() {
		return this.ySize;
	}

	/**Returns grid in printableString form
	 * @return String returnString
	 */
	public String getString() {
		String returnString = "[";
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				returnString += grid.get(i).get(j).toString();
				if (j < this.getxSize() - 1) {
					returnString += ", ";
				}
			}
			if (i < this.getySize() - 1) {
				returnString += "\n ";
			}
		}
		return returnString + "]";
	}

	/**Gets object at a specific coordinate
	 * @param xCoord
	 * @param yCoord
	 * @return returnObject
	 */
	public Object getVal(int xCoord, int yCoord) {
		Object returnObject = new Object();
		try {
			returnObject = grid.get(yCoord).get(xCoord);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return returnObject;
	}

	/**Inserts new object at coordinate
	 * @param xCoord
	 * @param yCoord
	 * @param obj
	 */
	public void addVal(int xCoord, int yCoord, Object obj) {
		grid.get(yCoord).add(xCoord, (T) obj);
		this.xSize = grid.get(yCoord).size();
		this.ySize = grid.size();
	}

	/**Modifies object at specific coordinate
	 * @param xCoord
	 * @param yCoord
	 */
	public void setVal(int xCoord, int yCoord, Object obj) {
		grid.get(yCoord).set(xCoord, (T) obj);
	}

	@Override
	public Iterator<T> iterator() {
		return (Iterator<T>) grid.iterator();
	}
}