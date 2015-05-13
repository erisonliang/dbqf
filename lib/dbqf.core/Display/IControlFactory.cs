﻿using dbqf.Configuration;
using dbqf.Criterion;
using System;
using System.Collections.Generic;
using System.Text;
using dbqf.Display;
using dbqf.Display.Builders;

namespace dbqf.Display
{
    public interface IControlFactory<T>
    {
        /// <summary>
        /// Creates a control for a field path.
        /// </summary>
        /// <param name="path">The field path that may be used to determine the control to build.</param>
        /// <param name="builder">The parameter builder that may be used to determine the control to build.</param>
        /// <returns></returns>
        UIElement<T> Build(FieldPath path, ParameterBuilder builder);

        /// <summary>
        /// Occurs when a control is built that could support a list of suggestions.
        /// </summary>
        event ListRequestedEventHandler ListRequested;
    }
}