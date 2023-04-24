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

    // 30분 마다 동작한다.
    private readonly int COLLECT_INTERVAL_TIME = 30 * 60 * 1000;

    public string processData(string data)
    {
        return data.ToUpper();
    }

    public void Start()
    {
        _logger.Info("Start Pub");

        using(var context = new ZContext())
        using(var publisher = new ZSocket(context, ZSocketType.PUB))
        {
            publisher.Bind(URI);

            while(true)
            {
                // 모든 지역의 정보를 담고 있는다.








                
            }
        }
    }
}
