namespace WasteCollectionManagement.Model.Models
{
    public enum BinTypesDescription { None = 0, Orange = 1, Yellow = 2, Brown = 3, Blue = 4, Green = 5 }
    public class BinType
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
