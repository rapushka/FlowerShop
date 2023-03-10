using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Flower_shop.ЗаказыDataSetTableAdapters;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;
using AccessoriesRow = Flower_shop.ЗаказыDataSet.Каталог_аксессуаровRow;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;
using FlowerRow = Flower_shop.ЗаказыDataSet.Каталог_цветовRow;

namespace Flower_shop
{
	public partial class OrderFillingForm : Form
	{
		private readonly ЗаказыDataSet.ЗаказRow _currentOrder;

		private readonly BindingList<AccessoriesInOrderRow> _accessoriesInOrder;
		private readonly BindingList<FlowersInOrderRow> _flowersInOrder;

		public OrderFillingForm(ЗаказыDataSet.ЗаказRow currentOrder)
		{
			_currentOrder = currentOrder;

			_accessoriesInOrder = new BindingList<AccessoriesInOrderRow>();
			_flowersInOrder = new BindingList<FlowersInOrderRow>();

			InitializeComponent();
		}

		private AccessoriesRow SelectedAccessoryFromCatalog
			=> заказыDataSet.Каталог_аксессуаров[AccessoriesDataGrid.IndexOfSelectedRow()];

		private FlowerRow SelectedFlowerFromCatalog
			=> заказыDataSet.Каталог_цветов[FlowersDataGrid.IndexOfSelectedRow()];

		// ReSharper disable ConvertToAutoProperty - other part is in auto-generated file
		private Аксессуары_в_заказеTableAdapter AccessoriesInOrderTableAdapter => аксессуары_в_заказеTableAdapter;
		private Цветы_в_заказеTableAdapter      FlowersInOrderTableAdapter     => цветы_в_заказеTableAdapter;

		private void OrderFillingForm_Load(object sender, EventArgs e)
		{
			заказTableAdapter.Fill(заказыDataSet.Заказ);
			вид_цветовTableAdapter.Fill(заказыDataSet.Вид_цветов);
			FlowersInOrderTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			AccessoriesInOrderTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);

			_accessoriesInOrder.AddRange(GetAccessoriesInOrder());
			_flowersInOrder.AddRange(GetFlowersInOrder());

			AccessoriesInOrderDataGrid.DataSource = _accessoriesInOrder;
			FlowersInOrderDataGrid.DataSource = _flowersInOrder;

			UpdateLabelValue();
		}

		private IList<AccessoriesInOrderRow> GetAccessoriesInOrder()
			=> AccessoriesInOrderTableAdapter.GetData()
			                                 .Where((aio) => aio.ID_заказа == _currentOrder.ID_заказа)
			                                 .ToList();

		private IList<FlowersInOrderRow> GetFlowersInOrder()
			=> FlowersInOrderTableAdapter.GetData()
			                             .Where((fio) => fio.ID_заказа == _currentOrder.ID_заказа)
			                             .ToList();

		private void NextButton_Click(object sender, EventArgs e)
		{
			_currentOrder.Стоимость = CalculateCost();
			var form = new DataSummaryForm(_currentOrder);
			SaveToDataBase();
			Close();
			form.ShowDialog();
		}

#region Buttons

		private void AddAccessoryButton_DoubleClick(object sender, EventArgs e)
		{
			AddAccessory();
			UpdateLabelValue();
		}

		private void AddAccessoryButton_Click(object sender, EventArgs e)
		{
			AddAccessory();
			UpdateLabelValue();
		}

		private void AddFlowerButton_Click(object sender, EventArgs e)
		{
			AddFlower();
			UpdateLabelValue();
		}

		private void AddFlowerButton_DoubleClick(object sender, EventArgs e)
		{
			AddFlower();
			UpdateLabelValue();
		}

		private void RemoveAccessoryButton_Click(object sender, EventArgs e)
		{
			RemoveAccessory();
			UpdateLabelValue();
		}

		private void RemoveAccessoryButton_DoubleClick(object sender, EventArgs e)
		{
			RemoveAccessory();
			UpdateLabelValue();
		}

		private void RemoveFlowerButton_Click(object sender, EventArgs e)
		{
			RemoveFlower();
			UpdateLabelValue();
		}

		private void RemoveFlowerButton_DoubleClick(object sender, EventArgs e)
		{
			RemoveFlower();
			UpdateLabelValue();
		}

#endregion

		private void AddAccessory()
		{
			var accessoryInOrder = _accessoriesInOrder.SingleOrDefault(IsSame);

			if (accessoryInOrder is null)
			{
				AddNewAccessory();
			}
			else
			{
				accessoryInOrder.Количество++;
				_accessoriesInOrder.ResetBindings();
			}
		}

		private void AddFlower()
		{
			var flowerInOrder = _flowersInOrder.SingleOrDefault(IsSame);

			if (flowerInOrder is null)
			{
				AddNewFlower();
			}
			else
			{
				flowerInOrder.Количество++;
				_flowersInOrder.ResetBindings();
			}
		}

		private void RemoveAccessory()
		{
			if (_accessoriesInOrder.Any() == false)
			{
				return;
			}

			var accessoryInOrder = _accessoriesInOrder.Single(Selected);

			accessoryInOrder.Количество--;

			if (accessoryInOrder.Количество <= 0)
			{
				_accessoriesInOrder.Remove(accessoryInOrder);
			}

			_accessoriesInOrder.ResetBindings();
		}

		private void RemoveFlower()
		{
			if (_flowersInOrder.Any() == false)
			{
				return;
			}

			var flowerInOrder = _flowersInOrder.Single(Selected);

			flowerInOrder.Количество--;

			if (flowerInOrder.Количество <= 0)
			{
				_flowersInOrder.Remove(flowerInOrder);
			}

			_flowersInOrder.ResetBindings();
		}

		private bool Selected(AccessoriesInOrderRow accessory)
			=> accessory.ID_аксессуара == AccessoriesInOrderDataGrid.SelectedAccessoryId();

		private bool Selected(FlowersInOrderRow flower)
			=> flower.ID_цветов == FlowersInOrderDataGrid.SelectedFlowerId();

		private bool IsSame(AccessoriesInOrderRow accessoryInOrder)
			=> accessoryInOrder.ID_аксессуара == SelectedAccessoryFromCatalog.ID_аксессуара;

		private bool IsSame(FlowersInOrderRow flowerInOrder)
			=> flowerInOrder.ID_цветов == SelectedFlowerFromCatalog.ID_цветов;

		private void AddNewAccessory()
		{
			var newAccessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			newAccessory.Количество = 1;
			newAccessory.Каталог_аксессуаровRow = SelectedAccessoryFromCatalog;
			newAccessory.ID_заказа = _currentOrder.ID_заказа;
			newAccessory.ID_аксессуара = SelectedAccessoryFromCatalog.ID_аксессуара;

			_accessoriesInOrder.Add(newAccessory);
		}

		private void AddNewFlower()
		{
			var newFlower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			newFlower.Количество = 1;
			newFlower.Каталог_цветовRow = SelectedFlowerFromCatalog;
			newFlower.ID_заказа = _currentOrder.ID_заказа;
			newFlower.ID_цветов = SelectedFlowerFromCatalog.ID_цветов;

			_flowersInOrder.Add(newFlower);
		}

		private void SaveToDataBase()
		{
			DeleteFromDbRemovedAccessories();
			DeleteFromDbRemovedFlowers();

			_accessoriesInOrder.ForEach(AccessoriesInOrderTableAdapter.InsertOrUpdate);
			_flowersInOrder.ForEach(FlowersInOrderTableAdapter.InsertOrUpdate);
		}

		private void DeleteFromDbRemovedAccessories()
		{
			foreach (var row in AccessoriesInOrderTableAdapter.GetData())
			{
				if (IsCurrentOrder(row)
				    && IsNotInList(row))
				{
					AccessoriesInOrderTableAdapter.Delete(row);
				}
			}
		}

		private void DeleteFromDbRemovedFlowers()
		{
			foreach (var row in FlowersInOrderTableAdapter.GetData())
			{
				if (IsCurrentOrder(row)
				    && IsNotInList(row))
				{
					FlowersInOrderTableAdapter.Delete(row);
				}
			}
		}

		private bool IsCurrentOrder(AccessoriesInOrderRow row) => row.ID_заказа == _currentOrder.ID_заказа;
		private bool IsCurrentOrder(FlowersInOrderRow row) => row.ID_заказа == _currentOrder.ID_заказа;

		private bool IsNotInList(AccessoriesInOrderRow row)
			=> _accessoriesInOrder.Any((aio) => aio.ID_аксессуаров_в_заказе == row.ID_аксессуаров_в_заказе) == false;
		private bool IsNotInList(FlowersInOrderRow row)
			=> _flowersInOrder.Any((fio) => fio.ID_цветов_в_заказе == row.ID_цветов_в_заказе) == false;

		private void UpdateLabelValue()
			=> TotalAmountLabel.Text = CalculateCost().ToString(CultureInfo.InvariantCulture);

		private decimal CalculateCost()
			=> _accessoriesInOrder.Sum((a) => a.Количество * GetPrice(a))
			   + _flowersInOrder.Sum((f) => f.Количество * GetPrice(f));

		private decimal GetPrice(AccessoriesInOrderRow accessory)
			=> accessory.Каталог_аксессуаровRow?.Цена ?? GetCatalogueRow(accessory).Цена;

		private decimal GetPrice(FlowersInOrderRow flower)
			=> flower.Каталог_цветовRow?.Цена ?? GetCatalogueRow(flower).Цена;

		private FlowerRow GetCatalogueRow(FlowersInOrderRow flower)
			=> каталог_цветовTableAdapter.GetData()
			                             .Single((a) => a.ID_цветов == flower.ID_цветов);

		private AccessoriesRow GetCatalogueRow(AccessoriesInOrderRow accessory)
			=> каталог_аксессуаровTableAdapter.GetData()
			                                  .Single((a) => a.ID_аксессуара == accessory.ID_аксессуара);
	}
}