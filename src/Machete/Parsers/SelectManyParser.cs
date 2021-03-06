﻿namespace Machete.Parsers
{
    using System;


    public class SelectManyParser<TInput, T, TSelect, TResult> :
        Parser<TInput, TResult>
    {
        readonly Parser<TInput, T> _parser;
        readonly Func<T, TSelect, TResult> _projector;
        readonly Func<T, Parser<TInput, TSelect>> _selector;

        public SelectManyParser(Parser<TInput, T> parser, Func<T, Parser<TInput, TSelect>> selector, Func<T, TSelect, TResult> projector)
        {
            _parser = parser;

            _selector = selector;
            _projector = projector;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            Result<Cursor<TInput>, T> parsed = _parser.Parse(input);
            if (parsed.HasResult)
            {
                T value = parsed.Result;
                Result<Cursor<TInput>, TSelect> selected = _selector(value).Parse(parsed.Next);
                if (selected.HasResult)
                {
                    TResult result = _projector(value, selected.Result);
                    return new Success<Cursor<TInput>, TResult>(result, selected.Next);
                }
            }

            return new Unmatched<Cursor<TInput>, TResult>(parsed.Next);
        }
    }
}