import java.security.InvalidParameterException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class TicTacToe {
	static char[][] gameBoard = {
			{' ', '|', ' ', '|', ' '},
			{'-', '+', '-', '+', '-'},
			{' ', '|', ' ', '|', ' '},
			{'-', '+', '-', '+', '-'},
			{' ', '|', ' ', '|', ' '}
	};
	static ArrayList<Integer> player1Positions = new ArrayList<Integer>();
	static ArrayList<Integer> player2Positions = new ArrayList<Integer>();
	static ArrayList<Integer> computerPositions = new ArrayList<Integer>();
	static boolean player1Win = false;
	static boolean player2Win = false;
	static boolean computerWin = false;
	static boolean tie = false;
	static boolean pvp = false;


	//MAIN
	public static void main(String[] args) {
		Scanner scnr = new Scanner(System.in);
		boolean playAgain = true;
		System.out.println("Welcome to Java Tic-Tac-Toe!");
		System.out.println("By: Harris A. Ransom");

		//While the user wants to continue playing
		while (playAgain) {
			//Determines if PvP or PvE
			System.out.println("Would you like to do a player-vs-player game (y/n)?");
			char nextChar = scnr.next().charAt(0);
			while ((nextChar != 'y') && (nextChar != 'n') && (nextChar != 'Y') && (nextChar != 'N')) {
				System.out.println("Input valid yes/no: ");
				nextChar = scnr.next().charAt(0);
			}
			if ((nextChar == 'y') || (nextChar == 'Y')) {
				pvp = true;
			}

			//Runs game based off of previous input
			if (pvp) { //Player based
				System.out.println("\nPlayer 1 is X, Player 2 is O\n");
				printBoard();

				//While there is no win condition
				while ((!player1Win) && (!player2Win) && (!tie)) {
					checkWin();
					playerMove(scnr, 1);
					printBoard();
					checkWin();
					playerMove(scnr, 2);
					printBoard();
					checkWin();
				}
				if (player1Win) {
					System.out.println("Player 1 wins!");
				}
				else if (player2Win) {
					System.out.println("Player 2 wins!");
				}
				else if (tie) {
					System.out.println("You tie!");
				}
			}
			else if (!pvp) { //Computer based
				System.out.println("\nPlayer 1 is X, Computer is O\n");
				printBoard();

				//While there is no win condition
				while ((!player1Win) && (!computerWin) && (!tie)) {
					playerMove(scnr, 1);
					printBoard();
					computerMove();
					printBoard();
					checkWin();
				}
				if (player1Win) {
					System.out.println("You win! :)");
				}
				else if (computerWin) {
					System.out.println("Computer wins! :(");
				}
				else if (tie) {
					System.out.println("You tie!");
				}
			}
			else {
				throw new IllegalStateException();
			}

			//Determines if player wants to play again
			System.out.println("Would you like to play again (y/n)?");
			nextChar = scnr.next().charAt(0);
			while ((nextChar != 'y') && (nextChar != 'n') && (nextChar != 'Y') && (nextChar != 'N')) {
				System.out.println("Input valid yes/no: ");
				nextChar = scnr.next().charAt(0);
			}
			if ((nextChar == 'y') || (nextChar == 'Y')) {
				playAgain = true;
				reset();
			}
			else {
				System.out.println("Thank you for playing Java Tic-Tac-Toe!");
				playAgain = false;
				scnr.close();
				System.exit(0);
			}
		}
	}

	//Outputs the current board
	public static void printBoard() {
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < gameBoard.length; i++) {
			for (int j = 0; j < gameBoard[i].length; j++) {
				sb.append(gameBoard[i][j]);
			}
			sb.append('\n');
		}
		System.out.println(sb.toString());
	}

	//Does 1 player move
	public static void playerMove(Scanner scnr, int playerNum) {
		int squareNum = -1;
		char playerChar;
		if (playerNum == 1) {
			playerChar = 'X';
		}
		else if (playerNum == 2) {
			playerChar = 'O';
		}
		else {
			throw new InvalidParameterException();
		}

		//Gets input
		System.out.println("Player " + playerNum + " Move!");
		System.out.println("Square number: ");
		squareNum = scnr.nextInt();
		while ((squareNum < 1) || (squareNum > 9) || (player1Positions.contains(squareNum)) || (player2Positions.contains(squareNum)) || (computerPositions.contains(squareNum))) {
			System.out.println("Input valid square number: ");
			squareNum = scnr.nextInt();
		}

		//Logs player move
		if (playerNum == 1) {
			player1Positions.add(squareNum);
		}
		else {
			player2Positions.add(squareNum);
		}

		//Modifies game board with player move
		switch (squareNum) {
		case 1:
			gameBoard[0][0] = playerChar; 
			break;
		case 2:
			gameBoard[0][2] = playerChar;
			break;
		case 3:
			gameBoard[0][4] = playerChar;
			break;
		case 4:
			gameBoard[2][0] = playerChar;
			break;
		case 5:
			gameBoard[2][2] = playerChar;
			break;
		case 6:
			gameBoard[2][4] = playerChar;
			break;
		case 7:
			gameBoard[4][0] = playerChar;
			break;
		case 8:
			gameBoard[4][2] = playerChar;
			break;
		case 9:
			gameBoard[4][4] = playerChar;
			break;
		default:
			System.out.println("Error in Player " + playerNum + " move! Restarting move...");
			playerMove(scnr, playerNum);
			break;
		}
	}

	//Does 1 computer move
	public static void computerMove() {
		Random rnd = new Random();
		int square = rnd.nextInt(9) + 1;
		System.out.println("Computer move!");

		//Generates random square
		while ((square < 1) || (square > 9) || (player1Positions.contains(square)) || (player2Positions.contains(square)) || (computerPositions.contains(square))) {
			square = rnd.nextInt(9) + 1;
		}

		//Logs computer move
		computerPositions.add(square);
		System.out.println("Computer moves in square " + square + "!");

		//Modifies game board with computer move
		switch (square) {
		case 1:
			gameBoard[0][0] = 'O'; 
			break;
		case 2:
			gameBoard[0][2] = 'O';
			break;
		case 3:
			gameBoard[0][4] = 'O';
			break;
		case 4:
			gameBoard[2][0] = 'O';
			break;
		case 5:
			gameBoard[2][2] = 'O';
			break;
		case 6:
			gameBoard[2][4] = 'O';
			break;
		case 7:
			gameBoard[4][0] = 'O';
			break;
		case 8:
			gameBoard[4][2] = 'O';
			break;
		case 9:
			gameBoard[4][4] = 'O';
			break;
		default:
			System.out.println("Error in Computer move! Restarting move...");
			computerMove();
			break;
		}
	}

	//Checks for a 3-in-a-row win condition or tie
	@SuppressWarnings({ "unchecked", "rawtypes" })
	public static void checkWin() {
		//Creates lists of win conditions
		List<Integer> topRow = Arrays.asList(1, 2, 3);
		List<Integer> middleRow = Arrays.asList(1, 2, 3);
		List<Integer> bottomRow = Arrays.asList(1, 2, 3);
		List<Integer> leftCol = Arrays.asList(1, 4, 7);
		List<Integer> middleCol = Arrays.asList(2, 5, 8);
		List<Integer> rightCol = Arrays.asList(3, 6, 9);
		List<Integer> diag1 = Arrays.asList(1, 5, 9);
		List<Integer >diag2 = Arrays.asList(3, 5, 7);

		//Creates a list of all the win conditions
		List<List> wins = new ArrayList<List>();
		wins.add(topRow);
		wins.add(middleRow);
		wins.add(bottomRow);
		wins.add(leftCol);
		wins.add(middleCol);
		wins.add(rightCol);
		wins.add(diag1);
		wins.add(diag2);

		//Tests for win conditions
		for (List<Integer> l : wins) {
			if (player1Positions.containsAll(l)) {
				player1Win = true;
				player2Win = false;
				computerWin = false;
			}
			else if (player2Positions.containsAll(l)) {
				player2Win = true;
				player1Win = false;
				computerWin = false;
			}
			else if (computerPositions.containsAll(l)) {
				computerWin = true;
				player1Win = false;
				player2Win = false;
			}
			else if ((pvp) && (player1Positions.size() + player2Positions.size() == 9)) {
				tie = true;
			}
			else if ((!pvp) && (player1Positions.size() + computerPositions.size() == 9)) {
				tie = true;
			}
		}
	}

	//Resets game
	public static void reset() {
		//Resets variables
		char[][] newGameBoard = {
				{' ', '|', ' ', '|', ' '},
				{'-', '+', '-', '+', '-'},
				{' ', '|', ' ', '|', ' '},
				{'-', '+', '-', '+', '-'},
				{' ', '|', ' ', '|', ' '}
		};
		player1Positions = new ArrayList<Integer>();
		player2Positions = new ArrayList<Integer>();
		computerPositions = new ArrayList<Integer>();
		player1Win = false;
		player2Win = false;
		computerWin = false;
		tie = false;
		pvp = false;
		
		//Resets game board
		for (int i = 0; i < newGameBoard.length; i++) {
			for (int j = 0; j < newGameBoard.length; j++) {
				gameBoard[i][j] = newGameBoard[i][j]; 
			}
		}
	}
}