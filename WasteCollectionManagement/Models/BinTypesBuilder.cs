namespace WasteCollectionManagement.Model.Models
{
    public class BinTypesBuilder
    {
        private readonly BinType _binTypes;

        public static BinTypesBuilder Create()
        {
            return new BinTypesBuilder();
        }

        private BinTypesBuilder()
        {
            _binTypes = new BinType();
        }

        public BinTypesBuilder ColouredOrange()
        {
            _binTypes.Id = (int)BinTypesDescription.Orange;
            return this;
        }

        public BinTypesBuilder ColouredYellow()
        {
            _binTypes.Id = (int)BinTypesDescription.Yellow;
            return this;
        }

        public BinTypesBuilder ColouredBrown()
        {
            _binTypes.Id = (int)BinTypesDescription.Brown;
            return this;
        }

        public BinTypesBuilder ColouredGreen()
        {
            _binTypes.Id = (int)BinTypesDescription.Green;
            return this;
        }

        public BinTypesBuilder ColouredBlue()
        {
            _binTypes.Id = (int)BinTypesDescription.Blue;
            return this;
        }

        public BinTypesBuilder WithDescription(string description)
        {
            _binTypes.Description = description;
            return this;
        }

        public BinType Build()
        {
            return _binTypes;
        }
    }
}
