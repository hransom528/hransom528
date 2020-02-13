import java.lang.reflect.Array;

@SuppressWarnings("unchecked")
public class gridOld <T> {
	private int xSize;
	private int ySize;
	private final Class<T> cls;
	private T[][] grid;
	private T[][] tempGrid;
	
	//Constructor
	public gridOld(Class<T> newClass, int xSize, int ySize) {
		this.xSize = xSize;
		this.ySize = ySize;
		this.cls = newClass;
		this.grid = (T[][]) Array.newInstance(newClass, xSize, ySize);
		this.tempGrid = (T[][]) Array.newInstance(newClass, xSize, ySize);
	}

	//Returns x 
	public int getxSize() {
		return xSize;
	}

	//Resizes array by setting new x
	public void setxSize(int xSize) {
		this.xSize = xSize;
		this.grid = (T[][]) Array.newInstance(this.cls, this.xSize, this.ySize);
	}

	//Returns y
	public int getySize() {
		return ySize;
	}

	/**Resizes array by setting new y
	 * @param ySize
	 */
	public void setySize(int ySize) {
		this.tempGrid = (T[][]) Array.newInstance(this.cls, this.xSize, this.ySize);
		this.ySize = ySize;
		
		for (int i = 0; i < this.grid.length; i++) {
			for (int j = 0; j < grid[0].length; j++) {
				this.tempGrid[i][j] = this.grid[i][j];
			}
		}
		
		this.grid = (T[][]) Array.newInstance(this.cls, this.xSize, this.ySize);
		for (int i = 0; i < this.tempGrid.length; i++) {
			for (int j = 0; j < this.tempGrid[0].length; j++) {
				this.grid[i][j] = this.tempGrid[i][j];
			}
		}
	}
	
	public void setPoint(int xCoord, int yCoord) {
		
	}
}