using System;

namespace Lab8Prog.Views
{
    public interface IModel
    {
        string firstPathText { get; set; }
        string secondPathText { get; set; }

        string modifiedText { get; set; }
    }
}
