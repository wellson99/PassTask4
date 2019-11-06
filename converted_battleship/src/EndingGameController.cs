
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using SwinGameSDK;

/// <summary>
/// The EndingGameController is responsible for managing the interactions at the end
/// of a game.
/// </summary>

static class EndingGameController
{

	/// <summary>
	/// Draw the end of the game screen, shows the win/lose state
	/// </summary>
	public static void DrawEndOfGame()
	{
		UtilityFunctions.DrawField(GameController.ComputerPlayer.PlayerGrid, GameController.ComputerPlayer, true);
		UtilityFunctions.DrawSmallField(GameController.HumanPlayer.PlayerGrid, GameController.HumanPlayer);

		if (GameController.HumanPlayer.IsDestroyed || (int)SwinGame.TimerTicks(GameController.Timer)>=120000) {
			SwinGame.DrawTextLines("-- YOU LOSE! --", Color.Red, Color.Black, GameResources.GameFont("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines ("Press Mouse 1 To Continue", Color.White, Color.Black, GameResources.GameFont ("ArialMedium"), FontAlignment.AlignCenter, 0, 340, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
			SwinGame.DrawTextLines ("Press Mouse 1 To Continue", Color.Black, Color.Black, GameResources.GameFont ("ArialMedium"), FontAlignment.AlignCenter, 0, 360, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		} else {
			SwinGame.DrawTextLines("-- WINNER --", Color.Green, Color.Black, GameResources.GameFont("ArialLarge"), FontAlignment.AlignCenter, 0, 250, SwinGame.ScreenWidth(), SwinGame.ScreenHeight());
			SwinGame.DrawTextLines ("Press Mouse 1 To Continue", Color.White, Color.Black, GameResources.GameFont ("ArialMedium"), FontAlignment.AlignCenter, 0, 340, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
			SwinGame.DrawTextLines ("Press Mouse 1 To Continue", Color.Black, Color.Black, GameResources.GameFont ("ArialMedium"), FontAlignment.AlignCenter, 0, 360, SwinGame.ScreenWidth (), SwinGame.ScreenHeight ());
		};
	}

	/// <summary>
	/// Handle the input during the end of the game. Any interaction
	/// will result in it reading in the highsSwinGame.
	/// </summary>
	public static void HandleEndOfGameInput()
	{
		if (SwinGame.MouseClicked(MouseButton.LeftButton) || SwinGame.KeyTyped(KeyCode.vk_RETURN) || SwinGame.KeyTyped(KeyCode.vk_ESCAPE)) {
			HighScoreController.ReadHighScore(GameController.HumanPlayer.Score);
			GameController.EndCurrentState();
		}
	}

}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
