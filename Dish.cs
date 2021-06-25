using System;

// Комплект еды, трапеза клиента.
namespace CustomerQueueControl
{
	[Serializable]
	class Dish
	{
		private static int _flapjackCounter;

		private readonly string _name;
		private readonly string _description;
		private readonly double _price;
		private readonly int _id;

		public string DisplayName => this._name;
		public string Description => this._description;
		public double Price => this._price;
		public string Name => this._name;
		public string Id => $"flp{this._id}";

		public Dish(string name, double price, string description = null)
		{
			this._name = name;
			this._price = price;
			this._description = description ?? name;
			this._id = (_flapjackCounter += 1);
		}


		public override string ToString()
		{
			return $"Flapjack {this._id} {this._name}";
		}
	}
}
