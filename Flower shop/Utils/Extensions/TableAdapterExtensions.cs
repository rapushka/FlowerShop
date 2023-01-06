using System.Linq;
using Flower_shop.ЗаказыDataSetTableAdapters;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;

namespace Flower_shop
{
	public static class TableAdapterExtensions
	{
		public static void Delete(this Аксессуары_в_заказеTableAdapter @this, AccessoriesInOrderRow accessory) 
			=> @this.Delete(accessory.ID_аксессуаров_в_заказе, null, null, null);
		
		public static void Delete(this Цветы_в_заказеTableAdapter @this, FlowersInOrderRow flower) 
			=> @this.Delete(flower.ID_цветов_в_заказе, flower.Количество, null, null);

		public static void InsertOrUpdate(this Аксессуары_в_заказеTableAdapter @this, AccessoriesInOrderRow accessory)
		{
			if (@this.GetData().Any(accessory.IsSame))
			{
				@this.Update(accessory);
				return;
			}

			@this.Insert
			(
				Количество: accessory.Количество,
				ID_заказа: accessory.ID_заказа,
				ID_аксессуара: accessory.ID_аксессуара
			);
		}

		public static void InsertOrUpdate(this Цветы_в_заказеTableAdapter @this, FlowersInOrderRow flower)
		{
			if (@this.GetData().Any(flower.IsSame))
			{
				@this.Update(flower);
				return;
			}

			@this.Insert
			(
				Количество: flower.Количество,
				ID_заказа: flower.ID_заказа,
				ID_цветов: flower.ID_цветов
			);
		}

		private static bool IsSame(this AccessoriesInOrderRow @this, AccessoriesInOrderRow other)
			=> other.ID_заказа == @this.ID_заказа && other.ID_аксессуара == @this.ID_аксессуара;

		private static bool IsSame(this FlowersInOrderRow @this, FlowersInOrderRow other)
			=> other.ID_заказа == @this.ID_заказа && other.ID_цветов == @this.ID_цветов;
	}
}