using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption.Models
{
    class Base64
    {


        static public string EncodeTo64(string toEncode)

        {

            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;

        }
        static public string DecodeFrom64(string encodedData)

        {

            byte[] encodedDataAsBytes= System.Convert.FromBase64String(encodedData);

            string returnValue =

               System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);

            return returnValue;

        }
    }

}
