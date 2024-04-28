namespace PetApi.Dtos
{
    public class PetPriceDto : BaseDto
    {
        public PetPriceDto() : base()
        {
            this.petId = 1;
            this.discountId = 1;
            this.price = 100;
            this.toalPrice = 100;
        }

        public int petId { get; set; }
        public byte? discountId { get; set; }
        public Double price { get; set; }
        public Double? discountAmount { get; set; }
        public Double toalPrice { get; set; }

    }

    public class PetDiscountDto : BaseDto
    {
        public PetDiscountDto()
        {
            this.discountId = 1;
            this.fromDate = DateTime.Now;
            this.tillDate = DateTime.Now;

        }


        public byte? discountId { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? tillDate { get; set; }
        public string? discountName { get; set; }
    }
}
