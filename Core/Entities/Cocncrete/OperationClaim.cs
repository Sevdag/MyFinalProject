using Core.Entities.Abstract;

namespace Core.Entities.Cocncrete
{
    public class OperationClaim :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
