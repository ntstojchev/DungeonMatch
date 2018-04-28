using UnityEngine.UI;

namespace Code.PlayerModel
{
	public class Player
	{
		public string Name { get; set; }

		public Image Avatar { get; set; }

		public Status Health { get; set; }

		public Status Coins { get; set; }

		public Status Attack { get; set; }

		public Status Poison { get; set; }

		public bool IsDead
		{
			get { return Health.Current < Health.Minimum; }
		}
	}
}
