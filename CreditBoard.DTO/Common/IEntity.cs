namespace CreditBoard.DTO
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
