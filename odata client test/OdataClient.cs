using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OData.Edm;
using Microsoft.OData.Client;
using System.Buffers;
using System.Globalization;
using System.Net;
using System.Reflection.Emit;

namespace odata_client_test
{
    internal class OdataClient
    {

        public void SendRequest()
        {

        }

        private void InvokeODataRequest<T>(Uri endpoint, Func<IEdmModel> getModel, Func<DataServiceContext, T> odataFunction)
        {
            var odataServiceContext = new DataServiceContext(endpoint);

            odataServiceContext.Format.LoadServiceModel = getModel;
            odataServiceContext.Format.UseJson();

            odataServiceContext.BuildingRequest += (sender, eventArgs) =>
            {
                eventArgs.RequestUri = null;
                eventArgs.Headers[""] = ""; 
            };

            try
            {
                var result = odataFunction(odataServiceContext);
                Console.WriteLine(result.ToString());
            }
            catch (DataServiceQueryException e)
            {
                Console.WriteLine(e.Message);

            }
        }
    }
}
