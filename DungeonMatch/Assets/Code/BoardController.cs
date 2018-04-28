using Code.Dungeon;
using Code.MatchThree;
using UnityEngine;

namespace Code
{
	public class BoardController : MonoBehaviour
	{
		public GameObject DungeonContentPrefab;
		public GameObject MatchThreeContentPrefab;

		public DungeonArtMapper DungeonArt;
		public MatchThreeArtMapper MatchThreeArt;

		private GameManager _game;
		private BoardGenerator _generator;

		private void Awake()
		{
			_game = GameManager.GetGame();
			_generator = new BoardGenerator();

			if (_game.GenerateBoardType == GameType.Dungeon)
				_generator.GenerateDungeonBoard(DungeonContentPrefab, DungeonArt);
			else if (_game.GenerateBoardType == GameType.MatchThree)
				_generator.GenerateMatchThreeBoard(MatchThreeContentPrefab, MatchThreeArt);
		}

		// Use this for initialization
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{

		}
	}
}
