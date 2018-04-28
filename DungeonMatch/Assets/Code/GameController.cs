using UnityEngine;

namespace Code
{
	public class GameController : MonoBehaviour
	{
		public BoardController Board;
		public GameType GenerateBoardType;

		private static GameController _instance;

		public static GameController GetGame()
		{
			return _instance;
		}

		private void Awake()
		{
			_instance = this;
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
