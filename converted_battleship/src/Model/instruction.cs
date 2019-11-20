using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

public class Instruction
{
	private const int LEFT = 20;
	private const int TOP = 50;

	public static void ExitInstruction ()
	{
		if (SwinGame.MouseClicked (MouseButton.LeftButton) || SwinGame.KeyTyped (KeyCode.vk_ESCAPE))
		{
			GameController.EndCurrentState ();
		}
	}

	public static void WriteInstruction ()
	{
		SwinGame.DrawText ("HOW TO PLAY BATTLESHIP GAME", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT + 280,20);
		SwinGame.DrawText ("-----------------------------------------------------------------------------------------------------------", Color.White, GameResources.GameFont ("Courier"), 0, 40);
		SwinGame.DrawText (">>Player will take turn to fire shots on opponent's battleship board", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 90);
		SwinGame.DrawText (">>Upon player's turn, click on a tile on the opponent's board to hit the opponent's ship", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 120);
		SwinGame.DrawText (">>If the player manage to hit a tile which contains a ship,", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 150);
		SwinGame.DrawText ("  the tile will turn into red coloured background", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 170);
		SwinGame.DrawText (">>If the tile is empty, the tile will turn into blue colored background", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 200);
		SwinGame.DrawText (">>The player will get another chance to hit the opponent's board if ", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 230);
		SwinGame.DrawText ("  player manage to hit the tile that contains a ship", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 250);
		SwinGame.DrawText (">>Otherwise, the other player will have their turn to hit the opponent's board.", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 280);
		SwinGame.DrawText (">>The game consist 5 ships with different sizes.", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 310);
		SwinGame.DrawText (">>Therefore, the player who hit all the 5 five ships first wins", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 340);
		SwinGame.DrawText (">>Each round of the game is only limited to 2 minutes and 30 seconds", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 370);
		SwinGame.DrawText (">>Player need to finish the game in the timegiven,or else the player will lose in the game", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT, 400);
		SwinGame.DrawText ("Press 'Esc' or 'Space' or 'Left Mouse Key' to exit the page", Color.White, GameResources.GameFont ("highscoreSmall"), LEFT + 150, 500);
	}

	public static void ViewInstruction ()
	{
		GameController.AddNewState (GameState.ViewInstruction);
		UtilityFunctions.DrawBackground ();
		WriteInstruction ();
	}
}
