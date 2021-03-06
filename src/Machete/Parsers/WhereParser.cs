﻿namespace Machete.Parsers
{
    using System;


    public class WhereParser<TInput, TResult> :
        Parser<TInput, TResult>
    {
        readonly Func<TResult, bool> _condition;
        readonly Parser<TInput, TResult> _parser;

        public WhereParser(Parser<TInput, TResult> parser, Func<TResult, bool> condition)
        {
            _parser = parser;
            _condition = condition;
        }

        public Result<Cursor<TInput>, TResult> Parse(Cursor<TInput> input)
        {
            return _parser.Parse(input).Where(_condition);
        }
    }
}