using Code.PlayerModel;
using Code.UI;
using UnityEngine;

namespace Code
{
	public class GameManager : MonoBehaviour
	{
		public BoardController Board;
		public GameType GenerateBoardType;
		public UIManager UIManager;

		private static GameManager _instance;

		public static GameManager GetGame()
		{
			return _instance;
		}

		private void Awake()
		{
			_instance = this;

			var player = new Player
			{
				Name = "Test player name",
				Health = new Status(0, 100),
				Coins = new Status(0, 200),
				Attack = new Status(0, 10)
			};
			UIManager.DrawPlayerData(player);
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
