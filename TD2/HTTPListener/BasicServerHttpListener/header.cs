using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebServer
{
    class Header
    {
        public static void DisplayWebHeaderCollection(HttpListenerRequest request)
        {
            System.Collections.Specialized.NameValueCollection headers = request.Headers;

            foreach (string key in headers.AllKeys)
            {
                string[] values = headers.GetValues(key);
                if (values.Length > 0)
                {
                    if (key.Equals("Accept"))
                    {
                        Console.WriteLine("The MIME types acceptable for the response are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Accept-Charset"))
                    {
                        Console.WriteLine("The character sets acceptable for the response are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Accept-Encoding"))
                    {
                        Console.WriteLine("The content encodings acceptable for the response are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Accept-Language"))
                    {
                        Console.WriteLine("The natural languages acceptable for the response are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Allow"))
                    {
                        Console.WriteLine("The HTTP methods supported are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Authorization"))
                    {
                        Console.WriteLine("The credentials that client must present to authenticate to the server are: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("Cookie"))
                    {
                        Console.WriteLine("The cookie data presented to the server is: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("From"))
                    {
                        Console.WriteLine("The Internet Email address for the human user who controls the requesting user agent is: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    if (key.Equals("User-Agent"))
                    {
                        Console.WriteLine("The information about the client agent is: ");
                        foreach (string value in values)
                        {
                            Console.WriteLine("   {0}", value);
                        }
                        continue;
                    }

                    /*
                    Console.WriteLine("The values of the {0} header are: ", key);
                    foreach (string value in values)
                    {
                        Console.WriteLine("   {0}", value);
                    }*/
                }
                else
                {
                    Console.WriteLine("There is no value associated with the header.");
                }
            }
        }
    }
}
