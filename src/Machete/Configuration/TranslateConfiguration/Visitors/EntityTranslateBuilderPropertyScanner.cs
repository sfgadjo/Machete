﻿namespace Machete.TranslateConfiguration.Visitors
{
    using System.Collections.Generic;
    using System.Reflection;
    using Internals.Extensions;


    public class EntityTranslateBuilderPropertyScanner<TResult, TInput, TSchema> :
        ITranslateBuilderPropertyScanner<TSchema>
        where TResult : TSchema
        where TInput : TSchema
        where TSchema : Entity
    {
        public void ScanProperties(HashSet<string> excludeProperties, ITranslateBuilderPropertyVisitor<TSchema> visitor)
        {
            foreach (PropertyInfo property in GetAllProperties())
            {
                if (excludeProperties.Contains(property.Name))
                    continue;

                visitor.Property(property);
            }
        }

        protected virtual IEnumerable<PropertyInfo> GetAllProperties()
        {
            return typeof(TResult).GetAllProperties();
        }
    }
}