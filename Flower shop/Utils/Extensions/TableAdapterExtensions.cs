using Flower_shop.ЗаказыDataSetTableAdapters;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;

namespace Flower_shop
{
	public static class TableAdapterExtensions
	{
		public static void Insert(this Цветы_в_заказеTableAdapter @this, FlowersInOrderRow flower)
			=> @this.Insert
			(
				Количество: flower.Количество,
				ID_заказа: flower.ID_заказа,
				ID_цветов: flower.Каталог_цветовRow.ID_цветов
			);

		public static void Insert(this Аксессуары_в_заказеTableAdapter @this, AccessoriesInOrderRow accessory)
			=> @this.Insert
			(
				Количество: accessory.Количество,
				ID_заказа: accessory.ID_заказа,
				ID_аксессуара: accessory.Каталог_аксессуаровRow.ID_аксессуара
			);
	}
}