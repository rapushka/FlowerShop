using System;
using System.ComponentModel;

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
	}
}