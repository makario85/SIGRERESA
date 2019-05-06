using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteCollectionManagement.Model.Models
{
    public enum ContainerTypeDescription { None = 0, Orange = 1, Yellow = 2, Brown = 3, Blue = 4, Green = 5 }
    public class ContainerType
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
