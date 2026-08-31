[![](https://img.shields.io/nuget/v/soenneker.notion.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.notion.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.notion.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.notion.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.notion.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.notion.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.notion.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.notion.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Notion.OpenApiClient

Typed request builders and models for calling the Notion API from .NET.

## Installation

```bash
dotnet add package Soenneker.Notion.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Notion.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", integrationToken);
httpClient.DefaultRequestHeaders.Add("Notion-Version", "2026-03-11");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new NotionOpenApiClient(adapter);
var currentUser = await client.V1.Users.Me.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.notion.com`. Its schema expects `Notion-Version: 2026-03-11` on requests.

For application registration, configuration-based credentials, and managed client reuse, use [`Soenneker.Notion.OpenApiClientUtil`](https://github.com/soenneker/soenneker.notion.openapiclientutil).
