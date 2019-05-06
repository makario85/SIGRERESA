using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasteCollectionManagement.Model.Models
{
    public class ContainerTypeBuilder
    {
        private readonly ContainerType _containerType;

        public static ContainerTypeBuilder Create()
        {
            return new ContainerTypeBuilder();
        }

        private ContainerTypeBuilder()
        {
            _containerType = new ContainerType();
        }

        public ContainerTypeBuilder ColouredOrange()
        {
            _containerType.Id = (int)ContainerTypeDescription.Orange;
            return this;
        }

        public ContainerTypeBuilder ColouredYellow()
        {
            _containerType.Id = (int)ContainerTypeDescription.Yellow;
            return this;
        }

        public ContainerTypeBuilder ColouredBrown()
        {
            _containerType.Id = (int)ContainerTypeDescription.Brown;
            return this;
        }

        public ContainerTypeBuilder ColouredGreen()
        {
            _containerType.Id = (int)ContainerTypeDescription.Green;
            return this;
        }

        public ContainerTypeBuilder ColouredBlue()
        {
            _containerType.Id = (int)ContainerTypeDescription.Blue;
            return this;
        }

        public ContainerTypeBuilder WithDescription(string description)
        {
            _containerType.Description = description;
            return this;
        }

        public ContainerType Build()
        {
            return _containerType;
        }
    }
}
