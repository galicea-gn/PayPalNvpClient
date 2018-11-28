using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Models
{
    public interface IRequest<TResponse> where TResponse : class
    {
        bool IsValidRequest();
        TResponse GenerateResponseObject(string formUrlEncodedString);
    }

    public interface IResponse { }
}
