using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using WatsonWebserver;

class RestRequest
{
    private static Server _server = null;
    private static readonly int REST_PORT = 50000;
    private static readonly string REST_ADDRESS = "127.0.0.1";

    private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

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
            _logger.Error(e);
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

            bool result = true;

            try
            {
                var responsedata = JsonConvert.DeserializeObject<Dictionary<string, string>>(ctx.Request.DataAsString);

                if (!responsedata.ContainsKey("subArea"))
                {
                    throw new Exception("Parameter error");
                }
   
            }
            catch(Exception e) 
            {
                _logger.Error(e);
                result = false;
            }
           
            await ctx.Response.Send(JsonConvert.SerializeObject(new { success = result }));
        });

        // agent 삭제
        _server.Routes.Static.Add(HttpMethod.POST, "/agent/delete", async (ctx) =>
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            // 삭제 코드 등록
            
        });
    }
}