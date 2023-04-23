# weatherPubSub

## 개요
  - 시험 알리미 서버/클라이언트(Pub/Sub ZeroMq 기반) 개발 전 ZeroMq에 대한이해도를 높이기 위해 시작한 미니 프로젝트이며,
    서버는 다수의 도시들의 날씨 정보를 수집하고 구독중인 클라이언트에게 해당 날씨 정보를 전송한다.
  
</br>
 
 
## Server 
### 1.  기능 
  - 날씨 정보 수집 
    - 기상청 Open API로 설정된 특정지역들의 날씨 정보 30분 마다 요청 
      - 기상청에서 제공하는 2단계 방식으로 지역 설정</br>
        ![image](https://user-images.githubusercontent.com/37799491/233822351-77c47732-325f-4c01-97e7-6c437cae99b9.png)
      - API 요청 정보 (기상청 제공)</br>
        Method : GET </br>
        ![image](https://user-images.githubusercontent.com/37799491/233821777-a6459874-aca0-41c2-ada7-60146e02c107.png)
      - API 응답 정보 (기상청 제공)</br>
        DATATYPE : JSON </br>
        ![image](https://user-images.githubusercontent.com/37799491/233821936-34f97f5e-3216-493e-94ef-95a07971a841.png)
  - 클라이언트 날씨 정보 전송
    - 날씨 정보가 수집되는 즉시 특정지역 마다 구독중인 구독자들에게 날씨 정보 전달  
  - 지역별 X,Y 좌표 관리 기능 
    - 기상청에서 제공하는 지역 별 X,Y 좌표 자료 관리
### 2. 구조 
  - C# .NET 기반 
  
</br>

## Client
### 1. 기능
  - 날씨 정보 서비스 구독
    - 서버에 특정 도시 날씨 정보 구독 요청
  - 날씨 알리미 기능 
    - Tray 방식 또는 MessageBox 방식으로 30분 마다 수신받은 날씨 정보 알림
  - 서비스 정보 변경
    - 구독중인 지역 변경 기능 제공 
### 2. 구조
  - WPF 
  
### 3. 화면 
  - 접속 화면 
  - 알림 화면
  - 설정창 
