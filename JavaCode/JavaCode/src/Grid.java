import java.util.ArrayList;
import java.util.Iterator;

/**
 * @author Harris Ransom 
**/
@SuppressWarnings("unchecked")

public class Grid<T> implements Iterable<T> {
	private static final long serialVersionUID = 1L;
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
	
	/**Returns grid in String
	 * @return
	 */
	public String getString() {
		return grid.toString();
	}
	
	/**Gets object at a specific coordinate
	 * @param xCoord
	 * @param yCoord
	 * @return Object
	 */
	public Object getValAtCoord(int xCoord, int yCoord) {
		try {
			return grid.get(yCoord).get(xCoord);
		} catch (Exception e) {
			// TODO: handle exception
		}
	}
	
	/**Modifies object at specific coordinate
	 * @param xCoord
	 * @param yCoord
	 */
	public void setValAtCoord(int xCoord, int yCoord, Object obj) {
		grid.get(yCoord).set(xCoord, (T) obj);
	}

	@Override
	public Iterator<T> iterator() {
		// TODO Auto-generated method stub
		return null;
	}
}