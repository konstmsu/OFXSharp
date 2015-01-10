using FluentAssertions;
using FluentAssertions.Specialized;
using System;

namespace OFXSharp.Tests
{
    public static class AssertEx
    {
        public static ExceptionAssertions<TException> Throws<TException>(this Action action)
            where TException: Exception
        {
            return action.ShouldThrow<TException>();
        }
    }
}
