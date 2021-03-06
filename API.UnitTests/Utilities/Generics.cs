﻿namespace API.UnitTests
{
    public static class Generics
    {
        public static string TaskResponseNotFound = "Task not found.";
        public static string BoardResponseNotFound = "Board not found.";
        public static Domain.Models.Task Task = new Domain.Models.Task()
        {
            TaskId = 1,
            BoardId = 1,
            Description = "Hello World",
            Priority = Domain.Models.EPriority.low,
            IsCompleted = false
        };
        public static Domain.Models.Board Board = new Domain.Models.Board()
        {
            BoardId = 1,
            Name = "Tasks"
        };
    }
}
