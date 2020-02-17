import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;

/**
 * @author Harris Ransom
 * @param <T>
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

	@Override
	/**
	 * @see java.util.Collection#size()
	 */
	public int size() {
		if ((long) (this.getxSize() + this.getySize()) > Integer.MAX_VALUE) {
			return Integer.MAX_VALUE;
		}
		else {
			return (this.getxSize() * this.getySize());
		}
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
	public void add(int xCoord, int yCoord, Object obj) {

		grid.get(yCoord).add(xCoord, (T) obj);
		this.xSize = grid.get(yCoord).size();
		this.ySize = grid.size();
	}

	@Override
	/**
	 * @see java.util.Collection#add(java.lang.Object)
	 */
	public boolean add(T e) {
		try {
			this.add(this.getxSize() - 1, this.getySize() - 1, e);
			return true;
		} catch (Exception e2) {
			e2.printStackTrace();
			return false;
		}
	}

	@SuppressWarnings("unchecked")
	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#addAll(java.util.Collection)
	 */
	public boolean addAll(Collection<? extends T> c) {
		for (Object item : c) {		
			this.add((T) item);
		}
		return false;
	}

	@SuppressWarnings("unchecked")
	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#remove(java.lang.Object)
	 */
	public boolean remove(Object o) {
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				if (this.getVal(j, i).equals(o)) {
					this.setVal(j, i, (T) new Object());
				}
			}
		}
		return false;
	}

	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#clear()
	 */
	public void clear() {
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				this.setVal(j, i, new Object());
			}
		}
	}

	/**Returns grid in printable String form
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

	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#toArray()
	 */
	public Object[] toArray() {
		Object[] objArr = new Object[this.size()];
		int index = 0;
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				objArr[index] = this.getVal(j, i); 
			}
		}
		return objArr;
	}

	@SuppressWarnings({ "hiding", "unchecked" })
	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#toArray(java.lang.Object[])
	 */
	public <T> T[] toArray(T[] a) {
		T[] tArr = (T[]) new Object[this.size()];
		int index = 0;
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				tArr[index] = (T) this.getVal(j, i); 
			}
		}
		return tArr;
	}

	@SuppressWarnings("unchecked")
	@Override
	/*
	 * (non-Javadoc)
	 * @see java.lang.Iterable#iterator()
	 */
	public Iterator<T> iterator() {
		return (Iterator<T>) grid.iterator();
	}

	@Override
	/*
	 * @see java.util.Collection#contains(java.lang.Object)
	 */
	public boolean contains(Object o) {
		boolean bool = false;
		for (int i = 0; i < this.getySize(); i++) {
			for (int j = 0; j < this.getxSize(); j++) {
				if (this.getVal(j, i).equals(o)) {
					bool = true;
				}
			}
		}
		return bool;
	}

	@Override
	/*
	 * @see java.util.Collection#containsAll(java.util.Collection)
	 */
	public boolean containsAll(Collection<?> c) {
		boolean bool = false;

		return bool;
	}

	@Override
	/*
	 * (non-Javadoc)
	 * @see java.util.Collection#isEmpty()
	 */
	public boolean isEmpty() {
		boolean isEmpty = true;

		return isEmpty;
	}



	@Override
	public boolean removeAll(Collection<?> c) {
		// TODO Auto-generated method stub
		return false;
	}

	@Override
	public boolean retainAll(Collection<?> c) {
		// TODO Auto-generated method stub
		return false;
	}
}