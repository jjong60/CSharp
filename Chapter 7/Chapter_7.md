# 7장 웹 서비스 만들기

### 서버와 클라이언트 환경

- 서버와 클라이언트 환경, **서버는 서비스를 제공하는 자, 클라이언트는 서비스를 사용하는 주체**
- 서로 연결된 네트워크에서 서버와 클라이언트는 각자의 역할로 구분된 통신 장치임.
- 웹 서버는 인터넷을 통해 웹 페이지를 볼 수 있도록 서비스를 제공하는 서버
- 웹 서버에서 서비스를 요청하는 클라이언트는 웹 브라우저임. (ex 크롬 사파리, 파폭 등등)
- 웹 서버와 브라우저는 HTTP 프로토콜이라는 통신 방식을 사용함.
- HTTP (HyperText Transfer Protocol)
- HTTPS (HyperText Transfer Protocol over secure socket layer)
- **호스트**는 웹 브라우저의 주소 창에 입력하는 서버의 주소
- 파일 서버는 파일을 주고받는 서비스를 제공함.
- 파일 전송 시 **FTP**나 보안이 강화된 **SFTP** 통신 규격을 사용함.
- API 서버는 데이터를 주고받는 서비스를 제공함.
- 데이터를 주고받는 형식은 **XML**이나 **JSON** 포맷을 사용함.

### [ASP.NET](http://ASP.NET) 웹 서비스 만들기

```jsx
dotnet new webapp -o MyWebApp --no-https
```

- new webapp : 웹 앱 프로젝트를 만드는 명령어
- -o : 프로젝트 이름을 결정함.
- —no-https : 보안 기능을 활성화 하지 않겠다.

```jsx
.NET 7.0을(를) 시작합니다.
---------------------
SDK 버전: 7.0.102

원격 분석
---------
.NET 도구는 사용자 환경 개선을 위해 사용량 현황 데이터를 수집합니다. Microsoft에서 데이터를 수집하여 커뮤니티와 공유합니다. 원하는 셸을 사용하여 DOTNET_CLI_TELEMETRY_OPTOUT 환경 변수를 '1' 또는 'true'로 설정하여 원격 분석을 옵트아웃할 수 있습니다.

.NET CLI 도구 원격 분석에 대한 자세한 내용은 https://aka.ms/dotnet-cli-telemetry를 참조하세요.

----------------
ASP.NET Core HTTPS 개발 인증서를 설치했습니다.
인증서를 신뢰하려면 'dotnet dev-certs https --trust'를 실행합니다(Windows 및 macOS만).
HTTPS에 대한 자세한 정보: https://aka.ms/dotnet-https
----------------
첫 번째 앱 작성: https://aka.ms/dotnet-hello-world
새로운 기능 확인: https://aka.ms/dotnet-whats-new
설명서 살펴보기: https://aka.ms/dotnet-docs
GitHub에서 문제 보고 및 소스 찾기: https://github.com/dotnet/core
사용 가능한 명령을 보려면 'dotnet --help'를 사용하거나 https://aka.ms/dotnet-cli를 방문하세요.
--------------------------------------------------------------------------------------
"ASP.NET Core 웹앱" 템플릿이 성공적으로 생성되었습니다.
이 템플릿에는 Microsoft 이외의 타사 기술이 포함되어 있습니다. 자세한 내용은https://aka.ms/aspnetcore/7.0-third-party-notices을(를) 참조하세요.

생성 후 작업 처리 중...
C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp\MyWebApp.csproj 복원 중:
  복원할 프로젝트를 확인하는 중...
  C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp\MyWebApp.csproj을(를) 96 ms 동안 복원했습니다.
복원에 성공했습니다.
```

```jsx
dotnet watch run
```

```jsx
C:\Users\SSAFY>cd C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp

C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp>dotnet watch run
dotnet watch 🔥 Hot reload enabled. For a list of supported edits, see https://aka.ms/dotnet/hot-reload.
  💡 Press "Ctrl + R" to restart.
dotnet watch 🔧 Building...
  복원할 프로젝트를 확인하는 중...
  복원할 모든 프로젝트가 최신 상태입니다.
  MyWebApp -> C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp\bin\Debug\net7.0\MyWebApp.dll
dotnet watch 🚀 Started
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:5289
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\SSAFY\source\repos\Chapter 7\MyWebApp
```

- [http://localhost:5289](http://localhost:5289) 와 같이 호스트 이름과 포트 번호를 확인할 수 있음.
- HTML 태그와 C# 코드를 수정해 문구를 변경하거나 그림 삽입 등 다양한 기능 구현이 가능함.

- 웹 브라우저(클라이언트)가 웹 앱(웹 서버)에 요청하면 웹 앱은 index.cshtml 파일을 먼저 확인함.
- cshtml 파일은 C#과 HTML을 혼합해 사용할 수 있는 Razor 구문으로 표현된 파일임.
    - Razor는 닷넷 뷰 엔진으로 웹 서버에서 동작하며 클라이언트 요청에 따라 HTML을 생성, 전달함.
- @기호 뒤에는 C# 코드를 추가할 수 있으며 HTML 태그와 함께 사용됩니다.

```csharp
// index.cshtml

@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1> Hello World!!</h1>
    <p>서버 시간은 @DateTime.Now 입니다.</p>
</div>
```

- 웹 페이지 결과

![Untitled](7%E1%84%8C%E1%85%A1%E1%86%BC%20%E1%84%8B%E1%85%B0%E1%86%B8%20%E1%84%89%E1%85%A5%E1%84%87%E1%85%B5%E1%84%89%E1%85%B3%20%E1%84%86%E1%85%A1%E1%86%AB%E1%84%83%E1%85%B3%E1%86%AF%E1%84%80%E1%85%B5%20fa61af8d2d1c4739a6232811e91f6bb1/Untitled.png)

- 코드를 수정하고 저장하면 웹 브라우저에 자동으로 바뀐 코드가 적용됨.
- 서버의 index.cshtml 파일을 수정하면 클라이언트가 요청할 때 변경된 코드에 맞게 생성된 HTML 응답을 보내주고 클라이언트는 HTML 응답을 해석해 사용자에게 보여줌.

```csharp
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1> Hello World!!</h1>
    <p>오늘은 [@DateTime.Now.DayOfWeek] 입니다.</p>
</div>
```

- 도전코딩 웹 페이지 결과

![Untitled](7%E1%84%8C%E1%85%A1%E1%86%BC%20%E1%84%8B%E1%85%B0%E1%86%B8%20%E1%84%89%E1%85%A5%E1%84%87%E1%85%B5%E1%84%89%E1%85%B3%20%E1%84%86%E1%85%A1%E1%86%AB%E1%84%83%E1%85%B3%E1%86%AF%E1%84%80%E1%85%B5%20fa61af8d2d1c4739a6232811e91f6bb1/Untitled%201.png)

- index.cshtml 파일에서 코드는 @ 기호 뒤에 입력합니다. 코드 블록은 @{ } 처럼 중괄호 안에 여러 줄의 코드를 작성할 수 있음.