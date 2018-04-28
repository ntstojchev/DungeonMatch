using UnityEngine;
using UnityEngine.UI;
using Code.PlayerModel;

namespace Code.UI
{
	public class UIManager : MonoBehaviour
	{
		public PlayerUIController PlayerUIController;

		public void DrawPlayerData(Player player)
		{
			PlayerUIController.Name.text = player.Name;
			PlayerUIController.Health.text = player.Health.Current.ToString();
			PlayerUIController.Coins.text = player.Coins.Current.ToString();
			PlayerUIController.Attack.text = player.Attack.Current.ToString();
		}
	}
}
