﻿namespace Machete
{
    using System;
    using Parsers;
    using TextParsers;


    public static class OrExtensions
    {
        public static Parser<TContent, T> Or<TContent, T>(this Parser<TContent, T> first, Parser<TContent, T> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrParser<TContent, T>(first, second);
        }

        public static Parser<TInput, TResult> Or<TInput, TResult, T1, T2>(this Parser<TInput, T1> first, Parser<TInput, T2> second)
            where T1 : TResult
            where T2 : TResult
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrParser<TInput, TResult, T1, T2>(first, second);
        }

        public static TextParser Or(this TextParser first, TextParser second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrTextParser(first, second);
        }

        public static TextParser<T> Or<T>(this TextParser<T> first, TextParser<T> second)
        {
            if (first == null)
                throw new ArgumentNullException(nameof(first));
            if (second == null)
                throw new ArgumentNullException(nameof(second));

            return new OrTextParser<T>(first, second);
        }
    }
}