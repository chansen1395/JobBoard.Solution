using System.Collections.Generic;

namespace TripList.Models
{
    public class Item
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Packed { get; set; }
        public double Weight { get; set; }
        public int Id { get; }
        private static List<Item> _instances = new List<Item> { };

        public Item(string description, double price, bool packed, double weight)
        {
            Description = description;
            Price = price;
            Packed = packed;
            Weight = weight;

            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public static Item UpdateItem(int editId)
        {
            if (_instances[editId - 1].Packed)
            {
                _instances[editId -1 ].Packed = false;
                return _instances[editId - 1];
            }
            else
            {
                _instances[editId - 1].Packed = true;
                return _instances[editId - 1];
            }
        }
    }
}
