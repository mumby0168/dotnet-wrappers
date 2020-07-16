using System;
using System.Threading.Tasks;

namespace DotNetWrappers.Interfaces
{
    public interface ITaskWrapper
    {
        Task Run(Action execute);
    }
}