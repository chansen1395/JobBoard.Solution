using System.Collections.Generic;

namespace JobList.Models
{
    public class Opening
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContactInfo { get; set; }
        public int Id { get; }
        private static List<Opening> _instances = new List<Opening> { };

        public Opening(string title, string description, string contactInfo)
        {
            Title = title;
            Description = description;
            ContactInfo = contactInfo;

            // _instances.Add(this);
            // Id = _instances.Count;
        }

        // public static List<Opening> GetAll()
        // {
        //     return _instances;
        // }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        // public static Opening Find(int searchId)
        // {
        //     return _instances[searchId - 1];
        // }

        // public static Opening UpdateOpening(int editId)
        // {
        //     if (_instances[editId - 1].Packed)
        //     {
        //         _instances[editId -1 ].Packed = false;
        //         return _instances[editId - 1];
        //     }
        //     else
        //     {
        //         _instances[editId - 1].Packed = true;
        //         return _instances[editId - 1];
        //     }
        // }
    }
}
