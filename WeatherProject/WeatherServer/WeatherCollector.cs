using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class WeatherCollector
{
    private readonly string KMA_URL = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0";

    private readonly static NLog.Logger _logger =  NLog.LogManager.GetCurrentClassLogger();

    private readonly string RES_NAME = "/getUltraSrtNcst";

    // 기상청에서 할당받은 자신의 KEY 입력
    private readonly string SERVICE_KEY = "YOUR KEY";

    // localName은 지역 카테고리 1 + 카테고리 로 만든다. Res에 딕셔너리로 보관해야할듯 
    public JObject GetWeatherData(string localName)
    {
        _logger.Info($"날씨 정보 API 요청 : {localName}");

        JObject result = null;

        try
        {
            var restClient = new RestClient(KMA_URL);
            var req = new RestRequest(RES_NAME)
            {
                Timeout = 3000
            };
           
            req.AddQueryParameter("ServiceKey", SERVICE_KEY);
            req.AddQueryParameter("pageNo", "1");
            req.AddQueryParameter("numOfRows", "1000");
            req.AddQueryParameter("dataType", "JSON");

            // base_date 는 현재일자, base_time 은 현재 시간 기준중 가장 가까운 시간으로 설정한다.
            req.AddQueryParameter("base_date", "20230423");
            req.AddQueryParameter("base_time", "0600");
            
            // X.Y 좌표는 LOCALNAME 을 통해 지정
            req.AddQueryParameter("nx", "60");
            req.AddQueryParameter("ny", "127");

            var res = restClient.Get(req);

            if (res.StatusCode == HttpStatusCode.OK)
            {
                // 데이터가 제대로 왔는지 확인하고 왔으면 아니면 다른 방법 고민한다.
                result = JObject.Parse(res.Content);
            }

        }
        catch (Exception e)
        {
            _logger.Error("WeatherData Collect Error :{0}",e);
        }

        return result;
    }
}