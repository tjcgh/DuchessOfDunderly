using System;
namespace DuchessOfDunderly.DAL.Models
{
    public interface IArraySourced
    {
        void BuildFromArray(string[] fields);
    }
}