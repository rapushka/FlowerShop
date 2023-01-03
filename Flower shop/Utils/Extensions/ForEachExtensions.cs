using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Flower_shop
{
	public static class ForEachExtensions
	{
		public static void ForEach<T>(this BindingList<T> @this, Action<T> @do)
		{
			foreach (var item in @this)
			{
				@do.Invoke(item);
			}
		}

		public static void ForEach
		(
			this DataGridViewRowCollection @this,
			Action<DataGridViewRow> @do,
			Func<DataGridViewRow, bool> @if
		)
		{
			foreach (DataGridViewRow item in @this)
			{
				if (@if.Invoke(item))
				{
					@do.Invoke(item);
				}
			}
		}
	}
}