using System;
using Microsoft.OData.Edm;
using Microsoft.OData.Client;
using Microsoft.OData.Edm.Csdl;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace odata_client_test
{
    internal class OdataClient
    {
        private string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyIsImtpZCI6Ii1LSTNROW5OUjdiUm9meG1lWm9YcWJIWkdldyJ9.eyJhdWQiOiI5OTZkZWYzZC1iMzZjLTQxNTMtODYwNy1hNmZkM2MwMWI4OWYiLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC8xNWFjNDY2Yi0yNmI5LTRjM2QtODYxNy0yZjczYjJkMzVmYjcvIiwiaWF0IjoxNjk1NjQwOTYxLCJuYmYiOjE2OTU2NDA5NjEsImV4cCI6MTY5NTY0NDkxNywiYWNyIjoiMSIsImFpbyI6IkFUUUF5LzhVQUFBQTM5elVRNis1U0VxTmIrNTlCUUU4Z2drM0xtQ0V3N0NxQVJMRjVOY1dRbFJRK0paUmJOYjI4TkpjblhIa2xZMk8iLCJhbXIiOlsicHdkIl0sImFwcGlkIjoiY2QwOTFhZDktYWEwZS00NWZlLWFhNzAtNGY1Zjk5YjVlMGJkIiwiYXBwaWRhY3IiOiIyIiwiZmFtaWx5X25hbWUiOiJBZG1pbmlzdHJhdG9yIiwiZ2l2ZW5fbmFtZSI6Ik1PRCIsImlwYWRkciI6IjJhMDA6ZmQwMDo4MDlkOjg3MDA6MzlkMTo4YzE5OjQwMmQ6OGRlMSIsIm5hbWUiOiJNT0QgQWRtaW5pc3RyYXRvciIsIm9pZCI6Ijc3ZDFkNTFlLTE0MGItNDI4ZS04ODY5LTlmNGUwMGIxZTQxNCIsInB1aWQiOiIxMDAzMjAwMkVGOTEwRjYyIiwicmgiOiIwLkFiMEFhMGFzRmJrbVBVeUdGeTl6c3ROZnR6M3ZiWmxzczFOQmhnZW1fVHdCdUpfTEFOdy4iLCJzY3AiOiJGaW5hbmNpYWxzLlJlYWRXcml0ZS5BbGwiLCJzdWIiOiJDMU9Zak1kQTFfTzZmcUZMSWk2WmlRY3dYZ1ZzYi1XeVBjNnJaMi1GYmxnIiwidGlkIjoiMTVhYzQ2NmItMjZiOS00YzNkLTg2MTctMmY3M2IyZDM1ZmI3IiwidW5pcXVlX25hbWUiOiJhZG1pbkBNMzY1QjQ1MTk5OC5vbm1pY3Jvc29mdC5jb20iLCJ1cG4iOiJhZG1pbkBNMzY1QjQ1MTk5OC5vbm1pY3Jvc29mdC5jb20iLCJ1dGkiOiJaQmJacDlZVnNFYWN6TXdHV0ZvTEFBIiwidmVyIjoiMS4wIiwid2lkcyI6WyI2MmU5MDM5NC02OWY1LTQyMzctOTE5MC0wMTIxNzcxNDVlMTAiLCJiNzlmYmY0ZC0zZWY5LTQ2ODktODE0My03NmIxOTRlODU1MDkiXX0.rwCT-RpTX9YCL-HbZ_aeMY26Iece3i5XN_YMhxV9JxO74Q1Ac3cjbuvQUE8xON5KhQbB54HPXgcxeCCPw5c11zcZnfQlgg1FoRvX2r-p5Iw8sUWw2fjw_ksdO4-kHmTM10snQEggFH0mk36-DJAOFal4JrD-sPN9x7bDK1FSC9tVveo1YMc43ZQDLVovX5D8l21ZlsCM2JPVYg4Sbll2gSHMgtPsZqkN7gKct0JpN2ZJ9x6Ud6XsSPhCx0nLPaXmP50PQTxtR9Ou-81j1P6JfLebw1VGxztCQalo250porivgTU1SUjAM257Evgzipr2WpE2JVG89tmTp8UMBrk8fw";

        public void SendRequestTest()
        {
            var url22 = new Uri("https://api.businesscentral.dynamics.com/v2.0/15ac466b-26b9-4c3d-8617-2f73b2d35fb7/sandbox/api/v2.0/externalbusinesseventdefinitions");
            var url23 = new Uri("https://api.businesscentral.dynamics.com/v2.0/15ac466b-26b9-4c3d-8617-2f73b2d35fb7/Test23/api/v2.0/externalbusinesseventdefinitions");
            var url23Meta = new Uri("https://api.businesscentral.dynamics.com/v2.0/15ac466b-26b9-4c3d-8617-2f73b2d35fb7/Test23/api/v2.0/$Metadata");
            /*

            this.InvokeODataRequest(url22, "./OldModel.xml");
            this.InvokeODataRequest(url22, "./NewModel.xml");

            this.InvokeODataRequest(url23, "./OldModel.xml");
            this.InvokeODataRequest(url23, "./NewModel.xml");
            */

            this.InvokeODataRequest(url22);

        }

        private void InvokeODataRequest(Uri url)
        {
            var model = this.GetModel(url);
            this.InvokeODataRequest(url, model);
        }

        private void InvokeODataRequest (Uri endpoint, string modelPath)
        {
            Console.WriteLine("With {modelPath}");
            this.InvokeODataRequest(endpoint, GetBusinessEventSubscriptionModel(modelPath));
        }

        private void InvokeODataRequest(Uri endpoint, IEdmModel model)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Calling {endpoint}");

            var odataServiceContext = new DataServiceContext(endpoint);
            odataServiceContext.Format.LoadServiceModel = () => model;

            odataServiceContext.Format.UseJson();
            odataServiceContext.BuildingRequest += (sender, eventArgs) =>
            {
                eventArgs.RequestUri = endpoint;
                eventArgs.Headers["Authorization"] = $"Bearer {token}";
                eventArgs.Headers["Accept"] = "application/json";
            };

            try
            {
                var oDataQuery = odataServiceContext.CreateQuery<BcBusinessEventDefinition>("externalbusinesseventdefinitions");
                var temp = oDataQuery.ToArray();
                foreach (var item in temp)
                {
                    Console.WriteLine($"Result: {item.DisplayName} + {item.Name} + {item.EventVersion}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException?.Message);
            }
            finally
            {
                Console.WriteLine("***********************************");
            }
        }

        private IEdmModel GetModel(Uri endpoint)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"Calling {endpoint} ");

            HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.businesscentral.dynamics.com/v2.0/15ac466b-26b9-4c3d-8617-2f73b2d35fb7/Sandbox/api/v2.0/$Metadata");

            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", $"Bearer {token}");

            try
            {                
                var temp = client.SendAsync(request);
                temp.Wait();
                var content = temp.Result.Content.ReadAsStringAsync().Result;
                Console.WriteLine("Success");

                using (var memStream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
                using (var reader = System.Xml.XmlReader.Create(memStream))
                {
                    var test =  CsdlReader.Parse(reader);
                    Console.WriteLine("success2?");
                    return test;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException?.Message);
                return null;
            }
            finally
            {
                Console.WriteLine("***********************************");
            }
        }

        private static IEdmModel GetBusinessEventSubscriptionModel(string path)
        {
            return CsdlReader.Parse(XmlReader.Create(path));            
        }
    }
}
