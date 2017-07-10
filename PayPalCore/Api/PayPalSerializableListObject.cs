﻿using System.Collections.Generic;

namespace PayPal.Api
{
    /// <summary>
    /// Represents a PayPal model object that can be serialized to and from JSON as an array.
    /// </summary>
    public class PayPalSerializableListObject<T> : List<T>, IPayPalSerializableObject
    {
        /// <summary>
        /// Converts this object to a JSON string.
        /// </summary>
        /// <returns>A JSON-formatted string.</returns>
        public virtual string ConvertToJson()
        {
            return JsonFormatter.ConvertToJson(this);
        }
    }
}
