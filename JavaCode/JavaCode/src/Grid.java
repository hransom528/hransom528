import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;

/**
 * The {@code Grid} class is a {@code Collection} of Objects of type T arranged in a 2D {@code ArrayList} pattern.
 *</br>
 *</br>
 * Please see {@link java.util.Collection} and {@link java.util.ArrayList} for more info.
 *
 * @author Harris Ransom
 * @author Ben Guerri
 * @version 1.0
 * @param <T> any valid type
 */
public class Grid<T> implements Iterable<T>, Collection<T>{
	private int xSize;
	private int ySize;
	private ArrayList<ArrayList<T>> grid;

	/**Grid Constructor
	 * @param xSize
	 * @param ySize
	 */
	@SuppressWarnings("unchecked")
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

	/**Returns specific array row size
	 * @return Current dimension for a specified row
	 */
	public int getxSize(int rowIndex) {
		return this.grid.get(rowIndex).size();
	}

	/**Returns current column size
	 * @return Current integer column dimension
	 */
	public int getYSize() {
		return this.grid.size();
	}

	/**Returns the initial X dimension
	 * @return Starting X integer dimension
	 */
	public int getStartXSize() {
		return this.xSize;
	}

	/**Returns initial Y dimension
	 * @return Starting Y integer dimension
	 */
	public int getStartYSize() {
		return this.ySize;
	}

	
	/**Gets total size of grid
	 * @see java.util.Collection#size()
	 */
	@Override
	public int size() {
		int size = 0;
		for (int i = 0; i < this.grid.size(); i++) {
			for (int j = 0; j < this.grid.get(i).size(); j++) {
				size += 1;
			}
		}
		return size;
	}

	/**Gets object at a specific coordinate in the grid
	 * @param xCoord
	 * @param yCoord
	 * @return Object at (xCoord, yCoord) of type T
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

	/**Modifies object at specific coordinate
	 * @param xCoord
	 * @param yCoord
	 */
	@SuppressWarnings("unchecked")
	public void setVal(int xCoord, int yCoord, Object obj) {
		grid.get(yCoord).set(xCoord, (T) obj);
	}

	/**Inserts new object at coordinate
	 * @param xCoord
	 * @param yCoord
	 * @param obj
	 */
	@SuppressWarnings("unchecked")
	public void add(int xCoord, int yCoord, Object obj) {
		grid.get(yCoord).add(xCoord, (T) obj);
	}

	/**Appends object to the end of the grid
	 * @see java.util.Collection#add(java.lang.Object)
	 * @param e object to be added
	 */
	@Override
	public boolean add(T e) {
		try {
			if (this.grid.get(this.grid.size() - 1).size() > this.getStartXSize()) {
				this.grid.add(new ArrayList<T>());
				this.add(this.grid.get(this.grid.size() - 1).size() - 1, this.grid.size() - 1, e);
			}
			else {
				this.add(this.grid.get(this.grid.size() - 1).size() - 1, this.grid.size() - 1, e);
			}
			return true;
		} catch (Exception e2) {
			e2.printStackTrace();
			return false;
		}
	}
	
	/**Adds all objects in collection c to grid
	 * @see java.util.Collection#addAll(java.util.Collection)
	 */
	@SuppressWarnings("unchecked")
	@Override
	public boolean addAll(Collection<? extends T> c) {
		for (Object item : c) {		
			this.add((T) item);
		}
		return false;
	}

	/**Removes object o from grid
	 * @see java.util.Collection#remove(java.lang.Object)
	 */
	@Override
	public boolean remove(Object o) {
		boolean bool = false;
		for (int i = 0; i < this.getYSize(); i++) {
			for (int j = 0; j < this.getxSize(i); j++) {
				if (this.getVal(j, i).equals(o)) {
					try {
						this.grid.get(i).remove(j);
						bool = true;
					} catch (Exception e) {
						e.printStackTrace();
					}
				}
			}
		}
		return bool;
	}

	/**Removes all objects in collection c from grid
	 * @see java.util.Collection#removeAll(java.util.Collection)
	 */
	@Override
	public boolean removeAll(Collection<?> c) {
		boolean bool = false;
		Object[] objs = new Object[c.size()];
		objs = c.toArray(objs);

		for (int a = 0; a < objs.length; a++) {
			for (int i = 0; i < this.getYSize(); i++) {
				for (int j = 0; j < this.getxSize(i); j++) {
					if (this.getVal(j, i).equals(objs[a])) {
						try {
							this.grid.get(i).remove(j);
							bool = true;
						} catch (Exception e) {
							e.printStackTrace();
						}
					}
				}
			}
		}
		return bool;
	}
	
	/**Clears grid
	 * @see java.util.Collection#clear()
	 */
	@Override
	public void clear() {
		for (int a = 0; a < 5; a++) {
			for (int i = 0; i < this.grid.size(); i++) {
				for (int j = 0; j < this.getxSize(i); j++) {
					this.grid.get(i).remove(j);
				}
			}
		}
	}

	/**Returns grid in printable String form
	 * @return String returnString
	 * @see java.util.Collection#toString() 
	 */
	@Override
	public String toString() {
		String returnString = "[";
		if (this.isEmpty()) {
			return returnString + "]";
		}
		else {
			for (int i = 0; i < this.grid.size(); i++) {
				for (int j = 0; j < this.grid.get(i).size(); j++) {
					returnString += grid.get(i).get(j).toString();
					if (j < this.grid.get(i).size() - 1) {
						returnString += ", ";
					}
				}
				if (i < this.getYSize() - 1) {
					returnString += "\n ";
				}
			}
		}
		return returnString + "]";
	}
	
	/**Returns grid in array form
	 * @see java.util.Collection#toArray()
	 */
	@Override
	public Object[] toArray() {

		Object[] objArr = new Object[this.size()];
		int index = 0;
		for (int i = 0; i < this.grid.size(); i++) {
			for (int j = 0; j < this.grid.get(i).size(); j++) {
				objArr[index] = this.getVal(j, i); 
				index++;
			}
		}
		return objArr;
	}

	/**Returns grid in array form in parameter array a
	 * @see java.util.Collection#toArray(java.lang.Object[])
	 * @param a Array to store result in
	 * @param <T>
	 */
	@SuppressWarnings({ "hiding", "unchecked" })
	@Override
	public <T> T[] toArray(T[] a) {
		int index = 0;
		if (a.length < this.size()) {
			T[] tArr = (T[]) new Object[this.size()];
			for (int i = 0; i < this.grid.size(); i++) {
				for (int j = 0; j < this.grid.get(i).size(); j++) {
					tArr[index] = (T) this.getVal(j, i); 
					index++;
				}
			}
			return tArr;
		}
		else {
			for (int i = 0; i < this.grid.size(); i++) {
				for (int j = 0; j < this.grid.get(i).size(); j++) {
					a[index] = (T) this.getVal(j, i); 
					index++;
				}
			}
			return a;
		}
	}

	/**Returns iterator
	 * @see java.lang.Iterable#iterator()
	 */
	@SuppressWarnings("unchecked")
	@Override
	public Iterator<T> iterator() {
		return (Iterator<T>) grid.iterator();
	}

	/**Determines if grid contains object o
	 * @see java.util.Collection#contains(java.lang.Object)
	 */
	@Override
	public boolean contains(Object o) {
		boolean bool = false;
		for (int i = 0; i < this.getYSize(); i++) {
			for (int j = 0; j < this.getxSize(i); j++) {
				if (this.getVal(j, i).equals(o)) {
					bool = true;
				}
			}
		}
		return bool;
	}

	/**Determines if grid contains all objects in collection c
	 * @see java.util.Collection#containsAll(java.util.Collection)
	 */
	@Override
	public boolean containsAll(Collection<?> c) {
		boolean returnBool = true;
		boolean[] bools = new boolean[c.size()];
		Object[] objs = new Object[c.size()];
		objs = c.toArray(objs);

		for(int a = 0; a < objs.length; a++) {
			for (int i = 0; i < this.getYSize(); i++) {
				for (int j = 0; j < this.getxSize(i); j++) {
					if (this.getVal(j, i).equals(objs[a])) {
						bools[a] = true;
					}
				}
			}
		}

		for (int i = 0; i < bools.length; i++) {
			if (!bools[i]) {
				returnBool = false;
			}
		}
		return returnBool;
	}

	/**Determines if grid is empty
	 * @see java.util.Collection#isEmpty()
	 */
	@Override
	public boolean isEmpty() {
		boolean isEmpty = true;
		for (int i = 0; i < this.grid.size(); i++) {
			if (!this.grid.get(i).isEmpty()) {
				isEmpty = false;
			}
		}
		return isEmpty;
	}

	/**Removes all items not in collection c from grid
	 * @see java.util.Collection#retainAll(java.util.Collection)
	 */
	@Override
	public boolean retainAll(Collection<?> c) {
		boolean bool = false;
		Object[] objs = new Object[c.size()];
		objs = c.toArray(objs);


		for (int i = 0; i < this.getYSize(); i++) {
			for (int j = 0; j < this.getxSize(i); j++) {
				for (int a = 0; a < objs.length; a++) {
					if (!this.getVal(j, i).equals(objs[a]) && (a == objs.length - 1)) {
						try {
							this.grid.get(i).remove(j);
							bool = true;
						} catch (Exception e) {
							e.printStackTrace();
						}
					}

				}
			}
		}
		//TODO: Fix retainAll
		return bool;
	}
}