using System.Collections.Generic;
using System.ComponentModel;

namespace Flower_shop
{
	public static class BindingListExtensions
	{
		public static void AddRange<T>(this BindingList<T> @this, IList<T> list)
		{
			foreach (var item in list)
			{
				@this.Add(item);
			}
		}
	}
}