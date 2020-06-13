using System;
using System.Collections.Generic;
using System.Linq;

namespace teacher_recruitment_app.Utilities
{
    public class PropertiesUtilities
    {

        public static List<string> GetSerializableProperties(string fields)
        {
            List<string> serializableProperties = new List<string>();
            if (!string.IsNullOrEmpty(fields))
            {
                var returnFields = fields.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                serializableProperties = returnFields.ToList();
            }

            return serializableProperties;
        }
    }
}