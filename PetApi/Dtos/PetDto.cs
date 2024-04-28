namespace PetApi.Dtos
{
    public class PetDto : BaseDto
    {
        public PetDto() : base()
        {
            this.petId = 1;
            this.petCode = Guid.NewGuid();
            this.petType = new PetTypeDto();
            this.petName = Guid.NewGuid().ToString();
            this.petCurrentPrice = 1;

        }
        public long petId { get; set; }
        public Guid? petCode { get; set; }
        public PetTypeDto? petType { get; set; }
        public string petName { get; set; }
        public bool? hasTail { get; set; }
        public double petCurrentPrice { get; set; }
    }

    public class PetTypeDto : BaseDto
    {
        public PetTypeDto()
        {
            this.petTypeId = 1;
            this.petTypeCode = Guid.NewGuid();
            this.petTypeName = Guid.NewGuid().ToString();
            this.petTypeGroup = new PetTypeGroupDto();
        }

        public Int64 petTypeId { get; set; }
        public Guid petTypeCode { get; set; }
        public string petTypeName { get; set; }
        public PetTypeGroupDto petTypeGroup { get; set; }
    }

    public class PetTypeGroupDto : BaseDto
    {
        public PetTypeGroupDto() : base()
        {
            this.petTypeGroupId = 1;
            this.petTypeGroupCode = Guid.NewGuid();
            this.petTypeGroupName = Guid.NewGuid().ToString();

        }
        public Int16 petTypeGroupId { get; set; }
        public Guid? petTypeGroupCode { get; set; }
        public string petTypeGroupName { get; set; }

    }
}
