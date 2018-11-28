using PayPalNvpClient.Exceptions;
using PayPalNvpClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PayPalNvpClient.Helpers
{
    public class RequestValidationHelper
    {
        public static IEnumerable<PropertyInfo> GetRequiredProperties(Type type) =>
            type.GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(RequiredNameValuePairAttribute)));

        public static bool IsValidRequest<TResponse>(IRequest<TResponse> request) where TResponse : class
        {
            var properties = GetRequiredProperties(request.GetType());

            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(request);
                if (propertyValue == null)
                {
                    throw new InvalidRequestException($"{property.Name} cannot be null when making a request to {request.GetMethod()}");
                }
                else if (string.IsNullOrWhiteSpace(propertyValue as string ?? "not null or whitespace since not a string"))
                {
                    throw new InvalidRequestException($"{property.Name} must have a value when making a request to {request.GetMethod()}");
                }
            }

            return true;
        }
    }
}
