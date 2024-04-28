namespace PetApi.Dtos
{
    public class BaseDto
    {
        public BaseDto()
        {
            this.id = Guid.NewGuid();
            this.insertDate = DateTime.Now;
        }

        public Guid id { get; set; }
        public DateTime insertDate { get; set; }
        public DateTime? updateDate { get; set; }
    }
}
