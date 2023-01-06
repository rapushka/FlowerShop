using System.Windows.Forms;

namespace Flower_shop
{
	public static class MessageBoxUtils
	{
		public static void ShowError(string message)
			=> MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
}