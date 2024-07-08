using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZeroMQ;

class Pub
{
    private readonly static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

    private readonly string URI = "tcp://127.0.0.1:55545";

    // 지역명 
    private Dictionary<string,object> _topics = new Dictionary<string,object>();

    // 30분 마다 동작한다.
    private readonly int COLLECT_INTERVAL_TIME = 1 * 60 * 1000;

    public string processData(string data)
    {
        return data.ToUpper();
    }

    public void Start()
    {
        _logger.Info("Start Pub");

        WeatherCollector.GetWeatherData();
        using (var context = new ZContext())
        using(var publisher = new ZSocket(context, ZSocketType.PUB))
        {
            publisher.Bind(URI);

            while(true)
            {
                foreach(var topic in _topics)
                {
                    using (var updateFrame = new ZFrame($"{topic.Key}--{topic.Value}"))
                    {
                        try
                        {
                            publisher.Send(updateFrame);
                        }
                        catch (Exception ex)
                        {
                            _logger.Error($"Fail to Send sub : {ex}");
                        }
                    }
                }

                Thread.Sleep(COLLECT_INTERVAL_TIME);
            }
        }
    }
}
