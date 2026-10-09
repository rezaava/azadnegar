using System;
namespace AzadNegar.Interfaces
{
    interface ICurrentViewChanged
    {
        Action CurrentViewChanged { get; set; }
    }
}
