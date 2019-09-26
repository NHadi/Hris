using System;

namespace Hris.Common
{
    public class Global
    {
        public static class API
        {
            public static string Version = "v1";
        }

        public static class Key
        {
            public static string Secret = "E546C8DF278CD5931069B522E695D4F2WongDermayu";
        }
        public static class DbConnection
        {
            public static string HrisConnection = "HrisConnection";            
        }

        public static class Method
        {
            public static string GET = "GET";
            public static string POST = "POST";
            public static string PUT = "PUT";
            public static string DELETE = "DELETE";
        }
    }
}
