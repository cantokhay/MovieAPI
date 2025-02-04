using MovieAPI.Domain.Entities.Abstract;
using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Domain.Entities.Concrete
{
    public class Review : IGenericEntity<Review>
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string ReviewComment { get; set; }
        public int ReviewUserRating{ get; set; }
        public DateTime ReviewDate{ get; set; }
        public ReviewStatus ReviewStatus { get; set; }
    }
}
