﻿using dbqf.Criterion.Values;

namespace dbqf.Criterion.Builders
{
    public class DateGtBuilder : ParameterBuilder
    {
        public DateGtBuilder()
        {
            Label = ">";
        }

        /// <summary>
        /// Works with DateValues.
        /// Only processes the first value.  Use JunctionBuilder to combine multiple.
        /// </summary>
        public override IParameter Build(FieldPath path, params object[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            if (values[0] is DateValue)
            {
                var date = (DateValue)values[0];
                return new SimpleParameter(path, ">=", date.Upper);
            }

            return null;
        }
    }
}