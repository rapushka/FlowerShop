using System.Windows.Forms;

namespace Flower_shop
{
	public static class DataGridExtensions
	{
		public static int IndexOfSelectedRow(this DataGridView @this) => @this.Rows.IndexOf(@this.SelectedRows[0]);
	}
}