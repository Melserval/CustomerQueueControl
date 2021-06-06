using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Комплект еды, трапеза клиента.
namespace Breackfast_for_Lamberjack
{
	class Flapjack
	{
		private static int _flapjackCounter;

		private  string _name;
		private  string _description;
		private  float _price;
		private readonly int _id;

		public string DisplayName => this._name;
		public string Name { get => _name; set => _name = value; }
		public string Description { get => this._description; set => _description = value; }
		public float Price { get => this._price; set => _price = value; }
		public string Id => $"flp{this._id}";

		public Flapjack() { this._id = (_flapjackCounter += 1); }

		public Flapjack(string name, float price, string description = null)
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
