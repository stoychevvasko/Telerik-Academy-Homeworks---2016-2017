namespace ProjectManager.Common.Providers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using Exceptions;

    public class Validator
    {
        public void Validate<T>(T objectToValidate) where T : class
        {
            var error = this.GetValidationErrors(objectToValidate);
            if (!(error.Count() == 0))
            {
                throw new UserValidationException(error.First());
            }
        }

        public IEnumerable<string> GetValidationErrors(object obj)
        {
            Type objectType = obj.GetType();
            PropertyInfo[] objectProperties = objectType.GetProperties();
            Type attrType = typeof(ValidationAttribute);

            foreach (var propertyInfo in objectProperties)
            {
                object[] customAttributes = propertyInfo.GetCustomAttributes(attrType, inherit: true);
                foreach (var customAttribute in customAttributes)
                {
                    var validationAttribute = (ValidationAttribute)customAttribute;
                    bool valid = validationAttribute.IsValid(propertyInfo.GetValue(obj, BindingFlags.GetProperty, null, null, null));
                    if (!valid)
                    {
                        yield return validationAttribute.ErrorMessage;
                    }
                }
            }
        }
    }
}