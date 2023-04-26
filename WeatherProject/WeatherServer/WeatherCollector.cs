using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


class Res
{
    // 실행 시 마다 파일읽어 오게 변경 한다.
    private static Dictionary<string, object> _localPoint;

    public static Dictionary<string, object> getLocalPoint()
    {
        if (_localPoint != null)
            return _localPoint;

        _localPoint = new Dictionary<string, object>();

        _localPoint["서울특별시:종로구"] = new { nx = 60, ny = 127 };
        _localPoint["서울특별시:중구"] = new { nx = 60, ny = 127 };
        _localPoint["서울특별시:용산구"] = new { nx = 60, ny = 126 };
        _localPoint["서울특별시:성동구"] = new { nx = 61, ny = 127 };
        _localPoint["서울특별시:광진구"] = new { nx = 62, ny = 126 };
        _localPoint["서울특별시:동대문구"] = new { nx = 61, ny = 127 };
        _localPoint["서울특별시:중랑구"] = new { nx = 62, ny = 128 };
        _localPoint["서울특별시:성북구"] = new { nx = 61, ny = 127 };
        _localPoint["서울특별시:강북구"] = new { nx = 61, ny = 128 };
        _localPoint["서울특별시:도봉구"] = new { nx = 61, ny = 129 };
        _localPoint["서울특별시:노원구"] = new { nx = 61, ny = 129 };
        _localPoint["서울특별시:은평구"] = new { nx = 59, ny = 127 };
        _localPoint["서울특별시:서대문구"] = new { nx = 59, ny = 127 };
        _localPoint["서울특별시:마포구"] = new { nx = 59, ny = 127 };
        _localPoint["서울특별시:양천구"] = new { nx = 58, ny = 126 };
        _localPoint["서울특별시:강서구"] = new { nx = 58, ny = 126 };
        _localPoint["서울특별시:구로구"] = new { nx = 58, ny = 125 };
        _localPoint["서울특별시:금천구"] = new { nx = 59, ny = 124 };
        _localPoint["서울특별시:영등포구"] = new { nx = 58, ny = 126 };
        _localPoint["서울특별시:동작구"] = new { nx = 59, ny = 125 };
        _localPoint["서울특별시:관악구"] = new { nx = 59, ny = 125 };
        _localPoint["서울특별시:서초구"] = new { nx = 61, ny = 125 };
        _localPoint["서울특별시:강남구"] = new { nx = 61, ny = 126 };
        _localPoint["서울특별시:송파구"] = new { nx = 62, ny = 126 };
        _localPoint["서울특별시:강동구"] = new { nx = 62, ny = 126 };
        _localPoint["부산광역시:중구"] = new { nx = 97, ny = 74 };
        _localPoint["부산광역시:서구"] = new { nx = 97, ny = 74 };
        _localPoint["부산광역시:동구"] = new { nx = 98, ny = 75 };
        _localPoint["부산광역시:영도구"] = new { nx = 98, ny = 74 };
        _localPoint["부산광역시:부산진구"] = new { nx = 97, ny = 75 };
        _localPoint["부산광역시:동래구"] = new { nx = 98, ny = 76 };
        _localPoint["부산광역시:남구"] = new { nx = 98, ny = 75 };
        _localPoint["부산광역시:북구"] = new { nx = 96, ny = 76 };
        _localPoint["부산광역시:해운대구"] = new { nx = 99, ny = 75 };
        _localPoint["부산광역시:사하구"] = new { nx = 96, ny = 74 };
        _localPoint["부산광역시:금정구"] = new { nx = 98, ny = 77 };
        _localPoint["부산광역시:강서구"] = new { nx = 96, ny = 76 };
        _localPoint["부산광역시:연제구"] = new { nx = 98, ny = 76 };
        _localPoint["부산광역시:수영구"] = new { nx = 99, ny = 75 };
        _localPoint["부산광역시:사상구"] = new { nx = 96, ny = 75 };
        _localPoint["부산광역시:기장군"] = new { nx = 100, ny = 77 };
        _localPoint["대구광역시:중구"] = new { nx = 89, ny = 90 };
        _localPoint["대구광역시:동구"] = new { nx = 90, ny = 91 };
        _localPoint["대구광역시:서구"] = new { nx = 88, ny = 90 };
        _localPoint["대구광역시:남구"] = new { nx = 89, ny = 90 };
        _localPoint["대구광역시:북구"] = new { nx = 89, ny = 91 };
        _localPoint["대구광역시:수성구"] = new { nx = 89, ny = 90 };
        _localPoint["대구광역시:달서구"] = new { nx = 88, ny = 90 };
        _localPoint["대구광역시:달성군"] = new { nx = 86, ny = 88 };
        _localPoint["인천광역시:중구"] = new { nx = 54, ny = 125 };
        _localPoint["인천광역시:동구"] = new { nx = 54, ny = 125 };
        _localPoint["인천광역시:미추홀구"] = new { nx = 54, ny = 124 };
        _localPoint["인천광역시:연수구"] = new { nx = 55, ny = 123 };
        _localPoint["인천광역시:남동구"] = new { nx = 56, ny = 124 };
        _localPoint["인천광역시:부평구"] = new { nx = 55, ny = 125 };
        _localPoint["인천광역시:계양구"] = new { nx = 56, ny = 126 };
        _localPoint["인천광역시:서구"] = new { nx = 55, ny = 126 };
        _localPoint["인천광역시:강화군"] = new { nx = 51, ny = 130 };
        _localPoint["인천광역시:옹진군"] = new { nx = 54, ny = 124 };
        _localPoint["광주광역시:동구"] = new { nx = 60, ny = 74 };
        _localPoint["광주광역시:서구"] = new { nx = 59, ny = 74 };
        _localPoint["광주광역시:남구"] = new { nx = 59, ny = 73 };
        _localPoint["광주광역시:북구"] = new { nx = 59, ny = 75 };
        _localPoint["광주광역시:광산구"] = new { nx = 57, ny = 74 };
        _localPoint["대전광역시:동구"] = new { nx = 68, ny = 100 };
        _localPoint["대전광역시:중구"] = new { nx = 68, ny = 100 };
        _localPoint["대전광역시:서구"] = new { nx = 67, ny = 100 };
        _localPoint["대전광역시:유성구"] = new { nx = 67, ny = 101 };
        _localPoint["대전광역시:대덕구"] = new { nx = 68, ny = 100 };
        _localPoint["울산광역시:중구"] = new { nx = 102, ny = 84 };
        _localPoint["울산광역시:남구"] = new { nx = 102, ny = 84 };
        _localPoint["울산광역시:동구"] = new { nx = 104, ny = 83 };
        _localPoint["울산광역시:북구"] = new { nx = 103, ny = 85 };
        _localPoint["울산광역시:울주군"] = new { nx = 101, ny = 84 };
        _localPoint["세종특별자치시:세종특별자치시"] = new { nx = 66, ny = 103 };
        _localPoint["경기도:수원시장안구"] = new { nx = 60, ny = 121 };
        _localPoint["경기도:수원시권선구"] = new { nx = 60, ny = 120 };
        _localPoint["경기도:수원시팔달구"] = new { nx = 61, ny = 121 };
        _localPoint["경기도:수원시영통구"] = new { nx = 61, ny = 120 };
        _localPoint["경기도:성남시수정구"] = new { nx = 63, ny = 124 };
        _localPoint["경기도:성남시중원구"] = new { nx = 63, ny = 124 };
        _localPoint["경기도:성남시분당구"] = new { nx = 62, ny = 123 };
        _localPoint["경기도:의정부시"] = new { nx = 61, ny = 130 };
        _localPoint["경기도:안양시만안구"] = new { nx = 59, ny = 123 };
        _localPoint["경기도:안양시동안구"] = new { nx = 59, ny = 123 };
        _localPoint["경기도:부천시"] = new { nx = 56, ny = 125 };
        _localPoint["경기도:광명시"] = new { nx = 58, ny = 125 };
        _localPoint["경기도:평택시"] = new { nx = 62, ny = 114 };
        _localPoint["경기도:동두천시"] = new { nx = 61, ny = 134 };
        _localPoint["경기도:안산시상록구"] = new { nx = 58, ny = 121 };
        _localPoint["경기도:안산시단원구"] = new { nx = 57, ny = 121 };
        _localPoint["경기도:고양시덕양구"] = new { nx = 57, ny = 128 };
        _localPoint["경기도:고양시일산동구"] = new { nx = 56, ny = 129 };
        _localPoint["경기도:고양시일산서구"] = new { nx = 56, ny = 129 };
        _localPoint["경기도:과천시"] = new { nx = 60, ny = 124 };
        _localPoint["경기도:구리시"] = new { nx = 62, ny = 127 };
        _localPoint["경기도:남양주시"] = new { nx = 64, ny = 128 };
        _localPoint["경기도:오산시"] = new { nx = 62, ny = 118 };
        _localPoint["경기도:시흥시"] = new { nx = 57, ny = 123 };
        _localPoint["경기도:군포시"] = new { nx = 59, ny = 122 };
        _localPoint["경기도:의왕시"] = new { nx = 60, ny = 122 };
        _localPoint["경기도:하남시"] = new { nx = 64, ny = 126 };
        _localPoint["경기도:용인시처인구"] = new { nx = 64, ny = 119 };
        _localPoint["경기도:용인시기흥구"] = new { nx = 62, ny = 120 };
        _localPoint["경기도:용인시수지구"] = new { nx = 62, ny = 121 };
        _localPoint["경기도:파주시"] = new { nx = 56, ny = 131 };
        _localPoint["경기도:이천시"] = new { nx = 68, ny = 121 };
        _localPoint["경기도:안성시"] = new { nx = 65, ny = 115 };
        _localPoint["경기도:김포시"] = new { nx = 55, ny = 128 };
        _localPoint["경기도:화성시"] = new { nx = 57, ny = 119 };
        _localPoint["경기도:광주시"] = new { nx = 65, ny = 123 };
        _localPoint["경기도:양주시"] = new { nx = 61, ny = 131 };
        _localPoint["경기도:포천시"] = new { nx = 64, ny = 134 };
        _localPoint["경기도:여주시"] = new { nx = 71, ny = 121 };
        _localPoint["경기도:연천군"] = new { nx = 61, ny = 138 };
        _localPoint["경기도:가평군"] = new { nx = 69, ny = 133 };
        _localPoint["경기도:양평군"] = new { nx = 69, ny = 125 };
        _localPoint["강원도:춘천시"] = new { nx = 73, ny = 134 };
        _localPoint["강원도:원주시"] = new { nx = 76, ny = 122 };
        _localPoint["강원도:강릉시"] = new { nx = 92, ny = 131 };
        _localPoint["강원도:동해시"] = new { nx = 97, ny = 127 };
        _localPoint["강원도:태백시"] = new { nx = 95, ny = 119 };
        _localPoint["강원도:속초시"] = new { nx = 87, ny = 141 };
        _localPoint["강원도:삼척시"] = new { nx = 98, ny = 125 };
        _localPoint["강원도:홍천군"] = new { nx = 75, ny = 130 };
        _localPoint["강원도:횡성군"] = new { nx = 77, ny = 125 };
        _localPoint["강원도:영월군"] = new { nx = 86, ny = 119 };
        _localPoint["강원도:평창군"] = new { nx = 84, ny = 123 };
        _localPoint["강원도:정선군"] = new { nx = 89, ny = 123 };
        _localPoint["강원도:철원군"] = new { nx = 65, ny = 139 };
        _localPoint["강원도:화천군"] = new { nx = 72, ny = 139 };
        _localPoint["강원도:양구군"] = new { nx = 77, ny = 139 };
        _localPoint["강원도:인제군"] = new { nx = 80, ny = 138 };
        _localPoint["강원도:고성군"] = new { nx = 85, ny = 145 };
        _localPoint["강원도:양양군"] = new { nx = 88, ny = 138 };
        _localPoint["충청북도:청주시상당구"] = new { nx = 69, ny = 106 };
        _localPoint["충청북도:청주시서원구"] = new { nx = 69, ny = 107 };
        _localPoint["충청북도:청주시흥덕구"] = new { nx = 67, ny = 106 };
        _localPoint["충청북도:청주시청원구"] = new { nx = 69, ny = 107 };
        _localPoint["충청북도:충주시"] = new { nx = 76, ny = 114 };
        _localPoint["충청북도:제천시"] = new { nx = 81, ny = 118 };
        _localPoint["충청북도:보은군"] = new { nx = 73, ny = 103 };
        _localPoint["충청북도:옥천군"] = new { nx = 71, ny = 99 };
        _localPoint["충청북도:영동군"] = new { nx = 74, ny = 97 };
        _localPoint["충청북도:증평군"] = new { nx = 71, ny = 110 };
        _localPoint["충청북도:진천군"] = new { nx = 68, ny = 111 };
        _localPoint["충청북도:괴산군"] = new { nx = 74, ny = 111 };
        _localPoint["충청북도:음성군"] = new { nx = 72, ny = 113 };
        _localPoint["충청북도:단양군"] = new { nx = 84, ny = 115 };
        _localPoint["충청남도:천안시동남구"] = new { nx = 63, ny = 110 };
        _localPoint["충청남도:천안시서북구"] = new { nx = 63, ny = 112 };
        _localPoint["충청남도:공주시"] = new { nx = 63, ny = 102 };
        _localPoint["충청남도:보령시"] = new { nx = 54, ny = 100 };
        _localPoint["충청남도:아산시"] = new { nx = 60, ny = 110 };
        _localPoint["충청남도:서산시"] = new { nx = 51, ny = 110 };
        _localPoint["충청남도:논산시"] = new { nx = 62, ny = 97 };
        _localPoint["충청남도:계룡시"] = new { nx = 65, ny = 99 };
        _localPoint["충청남도:당진시"] = new { nx = 54, ny = 112 };
        _localPoint["충청남도:금산군"] = new { nx = 69, ny = 95 };
        _localPoint["충청남도:부여군"] = new { nx = 59, ny = 99 };
        _localPoint["충청남도:서천군"] = new { nx = 55, ny = 94 };
        _localPoint["충청남도:청양군"] = new { nx = 57, ny = 103 };
        _localPoint["충청남도:홍성군"] = new { nx = 55, ny = 106 };
        _localPoint["충청남도:예산군"] = new { nx = 58, ny = 107 };
        _localPoint["충청남도:태안군"] = new { nx = 48, ny = 109 };
        _localPoint["전라북도:전주시완산구"] = new { nx = 63, ny = 89 };
        _localPoint["전라북도:전주시덕진구"] = new { nx = 63, ny = 89 };
        _localPoint["전라북도:군산시"] = new { nx = 56, ny = 92 };
        _localPoint["전라북도:익산시"] = new { nx = 60, ny = 91 };
        _localPoint["전라북도:정읍시"] = new { nx = 58, ny = 83 };
        _localPoint["전라북도:남원시"] = new { nx = 68, ny = 80 };
        _localPoint["전라북도:김제시"] = new { nx = 59, ny = 88 };
        _localPoint["전라북도:완주군"] = new { nx = 63, ny = 89 };
        _localPoint["전라북도:진안군"] = new { nx = 68, ny = 88 };
        _localPoint["전라북도:무주군"] = new { nx = 72, ny = 93 };
        _localPoint["전라북도:장수군"] = new { nx = 70, ny = 85 };
        _localPoint["전라북도:임실군"] = new { nx = 66, ny = 84 };
        _localPoint["전라북도:순창군"] = new { nx = 63, ny = 79 };
        _localPoint["전라북도:고창군"] = new { nx = 56, ny = 80 };
        _localPoint["전라북도:부안군"] = new { nx = 56, ny = 87 };
        _localPoint["전라남도:목포시"] = new { nx = 50, ny = 67 };
        _localPoint["전라남도:여수시"] = new { nx = 73, ny = 66 };
        _localPoint["전라남도:순천시"] = new { nx = 70, ny = 70 };
        _localPoint["전라남도:나주시"] = new { nx = 56, ny = 71 };
        _localPoint["전라남도:광양시"] = new { nx = 73, ny = 70 };
        _localPoint["전라남도:담양군"] = new { nx = 61, ny = 78 };
        _localPoint["전라남도:곡성군"] = new { nx = 66, ny = 77 };
        _localPoint["전라남도:구례군"] = new { nx = 69, ny = 75 };
        _localPoint["전라남도:고흥군"] = new { nx = 66, ny = 62 };
        _localPoint["전라남도:보성군"] = new { nx = 62, ny = 66 };
        _localPoint["전라남도:화순군"] = new { nx = 61, ny = 72 };
        _localPoint["전라남도:장흥군"] = new { nx = 59, ny = 64 };
        _localPoint["전라남도:강진군"] = new { nx = 57, ny = 63 };
        _localPoint["전라남도:해남군"] = new { nx = 54, ny = 61 };
        _localPoint["전라남도:영암군"] = new { nx = 56, ny = 66 };
        _localPoint["전라남도:무안군"] = new { nx = 52, ny = 71 };
        _localPoint["전라남도:함평군"] = new { nx = 52, ny = 72 };
        _localPoint["전라남도:영광군"] = new { nx = 52, ny = 77 };
        _localPoint["전라남도:장성군"] = new { nx = 57, ny = 77 };
        _localPoint["전라남도:완도군"] = new { nx = 57, ny = 56 };
        _localPoint["전라남도:진도군"] = new { nx = 48, ny = 59 };
        _localPoint["전라남도:신안군"] = new { nx = 50, ny = 66 };
        _localPoint["경상북도:포항시남구"] = new { nx = 102, ny = 94 };
        _localPoint["경상북도:포항시북구"] = new { nx = 102, ny = 95 };
        _localPoint["경상북도:경주시"] = new { nx = 100, ny = 91 };
        _localPoint["경상북도:김천시"] = new { nx = 80, ny = 96 };
        _localPoint["경상북도:안동시"] = new { nx = 91, ny = 106 };
        _localPoint["경상북도:구미시"] = new { nx = 84, ny = 96 };
        _localPoint["경상북도:영주시"] = new { nx = 89, ny = 111 };
        _localPoint["경상북도:영천시"] = new { nx = 95, ny = 93 };
        _localPoint["경상북도:상주시"] = new { nx = 81, ny = 102 };
        _localPoint["경상북도:문경시"] = new { nx = 81, ny = 106 };
        _localPoint["경상북도:경산시"] = new { nx = 91, ny = 90 };
        _localPoint["경상북도:군위군"] = new { nx = 88, ny = 99 };
        _localPoint["경상북도:의성군"] = new { nx = 90, ny = 101 };
        _localPoint["경상북도:청송군"] = new { nx = 96, ny = 103 };
        _localPoint["경상북도:영양군"] = new { nx = 97, ny = 108 };
        _localPoint["경상북도:영덕군"] = new { nx = 102, ny = 103 };
        _localPoint["경상북도:청도군"] = new { nx = 91, ny = 86 };
        _localPoint["경상북도:고령군"] = new { nx = 83, ny = 87 };
        _localPoint["경상북도:성주군"] = new { nx = 83, ny = 91 };
        _localPoint["경상북도:칠곡군"] = new { nx = 85, ny = 93 };
        _localPoint["경상북도:예천군"] = new { nx = 86, ny = 107 };
        _localPoint["경상북도:봉화군"] = new { nx = 90, ny = 113 };
        _localPoint["경상북도:울진군"] = new { nx = 102, ny = 115 };
        _localPoint["경상북도:울릉군"] = new { nx = 127, ny = 127 };
        _localPoint["경상남도:창원시의창구"] = new { nx = 90, ny = 77 };
        _localPoint["경상남도:창원시성산구"] = new { nx = 91, ny = 76 };
        _localPoint["경상남도:창원시마산합포구"] = new { nx = 89, ny = 76 };
        _localPoint["경상남도:창원시마산회원구"] = new { nx = 89, ny = 76 };
        _localPoint["경상남도:창원시진해구"] = new { nx = 91, ny = 75 };
        _localPoint["경상남도:진주시"] = new { nx = 81, ny = 75 };
        _localPoint["경상남도:통영시"] = new { nx = 87, ny = 68 };
        _localPoint["경상남도:사천시"] = new { nx = 80, ny = 71 };
        _localPoint["경상남도:김해시"] = new { nx = 95, ny = 77 };
        _localPoint["경상남도:밀양시"] = new { nx = 92, ny = 83 };
        _localPoint["경상남도:거제시"] = new { nx = 90, ny = 69 };
        _localPoint["경상남도:양산시"] = new { nx = 97, ny = 79 };
        _localPoint["경상남도:의령군"] = new { nx = 83, ny = 78 };
        _localPoint["경상남도:함안군"] = new { nx = 86, ny = 77 };
        _localPoint["경상남도:창녕군"] = new { nx = 87, ny = 83 };
        _localPoint["경상남도:고성군"] = new { nx = 85, ny = 71 };
        _localPoint["경상남도:남해군"] = new { nx = 77, ny = 68 };
        _localPoint["경상남도:하동군"] = new { nx = 74, ny = 73 };
        _localPoint["경상남도:산청군"] = new { nx = 76, ny = 80 };
        _localPoint["경상남도:함양군"] = new { nx = 74, ny = 82 };
        _localPoint["경상남도:거창군"] = new { nx = 77, ny = 86 };
        _localPoint["경상남도:합천군"] = new { nx = 81, ny = 84 };
        _localPoint["제주특별자치도:제주시"] = new { nx = 53, ny = 38 };
        _localPoint["제주특별자치도:서귀포시"] = new { nx = 52, ny = 33 };

        return _localPoint;
    }
}


class WeatherCollector
{
    private readonly static string KMA_URL = "http://apis.data.go.kr/1360000/VilageFcstInfoService_2.0";

    private readonly static NLog.Logger _logger =  NLog.LogManager.GetCurrentClassLogger();

    private readonly static string RES_NAME = "/getUltraSrtNcst";

    // 기상청에서 할당받은 자신의 KEY 입력
    private readonly static string SERVICE_KEY = "YOUR KEY";

    private static Dictionary<string, object> _localPoint = Res.getLocalPoint();

    // localName은 지역 카테고리 1 + 카테고리 로 만든다. Res에 딕셔너리로 보관해야할듯 
    public static JObject GetWeatherData(string localName)
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
            
            // 해당 값은 고정된 값이므로 건드리지 않는다.
            req.AddQueryParameter("ServiceKey", SERVICE_KEY);
            req.AddQueryParameter("pageNo", "1");
            req.AddQueryParameter("numOfRows", "1000");
            req.AddQueryParameter("dataType", "JSON");

            // base_date 는 현재일자, base_time 은 현재 시간 기준중 -1시간으로 설정한다
            req.AddQueryParameter("base_date", DateTime.Now.ToString("yyyyMMdd"));

            string baseTime = DateTime.Now.AddHours(-1).ToString("HHmm");
            req.AddQueryParameter("base_time", baseTime);

            foreach (var item in _localPoint)
            {
                dynamic obj = item.Value;

                int nx = obj.nx;
                int ny = obj.ny;

                req.AddQueryParameter("nx", nx.ToString());
                req.AddQueryParameter("ny", ny.ToString());


            }


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