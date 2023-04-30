using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonWebserver;

class RestRequest
{
    private static Server _server = null;
    private static readonly int REST_PORT = 50000;
    private static readonly string REST_ADDRESS = "127.0.0.1";

    public static string Start()
    {
        string result = null;

        try
        {
            _server = new Server(REST_ADDRESS, REST_PORT);
            
            SetRestHandlers();

            _server.Start();
        }
        catch (Exception e)
        {
            result = e.Message;
        }

        return result;
    }

    // Rest/API 
    private static void SetRestHandlers()
    {
        // agent 등록
        _server.Routes.Static.Add(HttpMethod.POST, "/agent/add", async (ctx) =>
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            var t = JsonConvert.DeserializeObject<Dictionary<string, string>>(ctx.Request.DataAsString);

            


            await ctx.Response.Send(JsonConvert.SerializeObject(keyValuePairs));
        });
    }
}