using System.Windows.Forms;

namespace Flower_shop
{
	public static class DataGridExtensions
	{
		private const int IndexOfColumnFlowerId = 3;
		private const int IndexOfColumnAccessoryId = 4;

		public static int IndexOfSelectedRow(this DataGridView @this) => @this.Rows.IndexOf(@this.SelectedRows[0]);

		public static int SelectedFlowerId(this DataGridView @this)
			=> (int)@this.SelectedRows[0].Cells[IndexOfColumnFlowerId].Value;
		
		public static int SelectedAccessoryId(this DataGridView @this)
			=> (int)@this.SelectedRows[0].Cells[IndexOfColumnAccessoryId].Value;
		
	}
}