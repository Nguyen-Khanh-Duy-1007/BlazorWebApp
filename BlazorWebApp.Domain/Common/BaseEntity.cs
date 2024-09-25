using BlazorWebApp.Domain.Common.Interfaces;

namespace BlazorWebApp.Domain.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
