using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVDMS.Application.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public bool IsFailure => !IsSuccess;

        public string? Error { get; }
        public T? Value { get; }

        protected Result(bool isSuccess, T? value, string? error)
        {
            if (isSuccess && error is not null)
                throw new ArgumentException("Successful result cannot have error.");

            if (!isSuccess && string.IsNullOrWhiteSpace(error))
                throw new ArgumentException("Failure result must have error.");

            IsSuccess = isSuccess;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value)
            => new(true, value, null);

        public static Result<T> Failure(string error)
            => new(false, default, error);
    }
}
