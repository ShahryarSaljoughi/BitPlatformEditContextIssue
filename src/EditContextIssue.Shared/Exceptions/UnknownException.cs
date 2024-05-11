﻿namespace EditContextIssue.Shared.Exceptions;

public class UnknownException : Exception
{
    public UnknownException()
        : base(nameof(AppStrings.UnknownException))
    {
    }

    public UnknownException(string message)
        : base(message)
    {
    }

    public UnknownException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
