using System.Linq;
using System.Windows.Forms;
using Flower_shop.ЗаказыDataSetTableAdapters;

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

		public static ЗаказыDataSet.ЗаказRow SelectedOrder(this DataGridView @this, ЗаказTableAdapter tableAdapter) 
			=> tableAdapter.GetData().Single((r) => r.ID_заказа == @this.SelectedOrderId());

		private static int SelectedOrderId(this DataGridView @this)
			=> (int)@this.SelectedRows[0].Cells[0].Value;
	}
}