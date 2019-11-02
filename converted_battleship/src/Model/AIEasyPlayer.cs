using System;

public class AIEasyPlayer : AIPlayer
	{
		private enum AIStates
		{
			Searching
		}

		private AIStates _CurrentState = AIStates.Searching;

		public AIEasyPlayer (BattleShipsGame game) : base(game)
		{
		}

		protected override void GenerateCoords (ref int row, ref int column)
		{
			do {
				//check which state the AI is in and uppon that choose which coordinate generation
				//method will be used.
				switch (_CurrentState) {
				case AIStates.Searching:
					SearchCoords (ref row, ref column);
					break;
				default:
					throw new ApplicationException ("AI has gone in an imvalid state");
				}
			} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid [row, column] != TileView.Sea));
			//while inside the grid and not a sea tile do the search
		}

		private void SearchCoords (ref int row, ref int column)
		{
			row = _Random.Next (0, EnemyGrid.Height);
			column = _Random.Next (0, EnemyGrid.Width);
		}

		protected override void ProcessShot (int row, int col, AttackResult result)
		{
			if (result.Value == ResultOfAttack.ShotAlready) {
			throw new ApplicationException ("Error in AI");
		}
		}
}
