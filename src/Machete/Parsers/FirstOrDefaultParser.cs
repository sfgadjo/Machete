﻿namespace Machete.Parsers
{
    using System.Collections.Generic;


    public class FirstOrDefaultParser<TInput, T> :
        Parser<TInput, T>
    {
        readonly Parser<TInput, IReadOnlyList<T>> _parser;
        readonly T _defaultValue;

        public FirstOrDefaultParser(Parser<TInput, IReadOnlyList<T>> parser, T defaultValue = default(T))
        {
            _parser = parser;
            _defaultValue = defaultValue;
        }

        public Result<Cursor<TInput>, T> Parse(Cursor<TInput> input)
        {
            var parsed = _parser.Parse(input);
            if (parsed.HasResult && parsed.Result.Count > 0)
            {
                return new Success<Cursor<TInput>, T>(parsed.Result[0], parsed.Next);
            }

            return new Success<Cursor<TInput>, T>(_defaultValue, input);
        }
    }
}