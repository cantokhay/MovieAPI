using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Domain.Entities.Abstract
{
    public interface IGenericEntity<T> where T : class
    {
        public int Id { get; set; }
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
