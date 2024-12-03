using System;

namespace AppVendas.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message){
            
        }
    }
}
