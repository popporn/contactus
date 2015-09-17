using System.Data.Entity;

namespace GFX.Core
{
    public interface IRepository
    {
        DbContext Context { get; set; }
    }
}