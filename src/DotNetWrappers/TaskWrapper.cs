using System;
using System.Threading.Tasks;
using DotNetWrappers.Interfaces;

namespace DotNetWrappers
{
    public class TaskWrapper : ITaskWrapper
    {
        public Task Run(Action execute)
        {
            return Task.Run(execute);
        }
    }
}