using MovieAPI.Domain.Entities.Abstract;
using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Domain.Entities.Concrete
{
    public class Category : IGenericEntity<Category>
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string CategoryName { get; set; }
    }
}
