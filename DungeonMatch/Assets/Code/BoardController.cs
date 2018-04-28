using Code.Dungeon;
using Code.MatchThree;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code
{
	

	public class BoardController : MonoBehaviour
	{
		public GameObject DungeonContentPrefab;
		public GameObject MatchThreeContentPrefab;

		public DungeonArtMapper DungeonArt;
		public MatchThreeArtMapper MatchThreeArt;

		private GameController _game;
		private BoardGenerator _generator;

		private void Awake()
		{
			_game = GameController.GetGame();
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
