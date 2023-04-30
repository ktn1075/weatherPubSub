using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Management;

namespace WeatherServer
{
    internal class Program
    {
        private static Thread _restThread = null;
        private readonly static NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            _restThread = new Thread(() =>
            {
                do
                {
                    string result = null;

                    try
                    {
                        result = RestRequest.Start();
                        if(result != null) 
                        {
                            throw new Exception(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex);
                    }
                    for (int i = 0; i < 60 && _restThread != null; i++)
                        Thread.Sleep(1000);
                }
                while (_restThread != null);
            })
            {
                IsBackground = true
            };

            _restThread.Start();

            Pub weatehrPub = new Pub();

            weatehrPub.Start();
        }   
    }
}
