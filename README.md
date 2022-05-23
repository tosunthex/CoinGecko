# CoinGecko
[![Build status](https://ci.appveyor.com/api/projects/status/wa1y561abqm9uflj?svg=true)](https://ci.appveyor.com/project/tosunthex/coingecko)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/94d224ae418e4473ad768f641f4ae419)](https://www.codacy.com/gh/tosunthex/CoinGecko/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=tosunthex/CoinGecko&amp;utm_campaign=Badge_Grade)![Nuget version](https://img.shields.io/nuget/v/CoinGeckoAsyncApi.svg)  ![Nuget downloads](https://img.shields.io/nuget/dt/CoinGeckoAsyncApi.svg)

CoinGecko .Net Standard api wrapper

A .Net wrapper for the CoinGecko Api as described on  [API documentation](https://www.coingecko.com/api?locale=en) , including all features the API provides using clear and readable objects.

If you think something is broken, something is missing or have any questions, please open an [Issue](https://github.com/tosunthex/CoinGecko/issues/new)

## Installation

Available on [Nuget](https://www.nuget.org/packages/CoinGeckoAsyncApi/).
```
pm> Install-Package CoinGeckoAsyncApi
```

## Quick start
```cs
...
using Newtonsoft.Json;
using CoinGecko.Clients;

HttpClient httpClient = new HttpClient();
JsonSerializerSettings serializerSettings = new JsonSerializerSettings();

PingClient pingClient = new PingClient(httpClient, serializerSettings);
SimpleClient simpleClient = new SimpleClient(httpClient, serializerSettings);

// Check CoinGecko API status
if ((await pingClient.GetPingAsync()).GeckoSays != string.Empty)
{
    // Getting current price of tether in usd
    string ids = "tether";
    string vsCurrencies = "usd";
    Console.WriteLine((await simpleClient.GetSimplePrice(new []{ids},new []{vsCurrencies}))["tether"]["usd"]);
}

...
```

## Examples
Examples can be found in the Test project.

## Available endpoint

[Refer to CoinGecko official API](https://www.coingecko.com/api)

|           Ping Endpoints                                    | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /ping                                                       |  [+]   |   [+]   | 
| /simple/price                                               |  [+]   |   [+]   | 
| /simple/token_price/{id}                                    |  [+]   |   [+]   |
| /simple/supported_vs_currencies                             |  [+]   |   [+]   |

|           Coins Endpoints                                   | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /coins/list                                                 |  [+]   |   [+]   | 
| /coins/market                                               |  [+]   |   [+]   | 
| /coins/{id}                                                 |  [+]   |   [+]   | 
| /coins/{id}/tickers                                         |  [+]   |   [+]   | 
| /coins/{id}/history                                         |  [+]   |   [+]   | 
| /coins/{id}/market_chart                                    |  [+]   |   [+]   |
| /coins/{id}/market_chart/range                              |  [-]   |   [-]   | 
| /coins/{id}/status_updates                                  |  [-]   |   [-]   | 
| /coins/{id}/ohlc                                            |  [+]   |   [+]   | 

|           Contact Endpoints                                 | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /coins/{id}/contract/{contract_address}                     |  [+]   |   [+]   | 
| /coins/{id}/contract/{contract_address}/market_chart/       |  [+]   |   [+]   | 
| /coins/{id}/contract/{contract_address}/market_chart/range  |  [+]   |   [+]   | 

|           Exchanges Endpoints                               | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /exchanges                                                  |  [+]   |   [+]   | 
| /exchanges/list                                             |  [+]   |   [+]   | 
| /exchanges/{id}                                             |  [+]   |   [+]   | 
| /exchanges/{id}/tickers                                     |  [+]   |   [+]   | 
| /exchanges/{id}/status_updates                              |  [-]   |   [-]   | 
| /exchanges/{id}/volume_chart                                |  [+]   |   [+]   | 

|           Finance Endpoints                                 | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /finance_platforms                                          |  [+]   |   [+]   | 
| /finance_products                                           |  [+]   |   [+]   | 

|           Derivatives Endpoints                             | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /derivatives                                                |  [+]   |   [+]   | 
| /derivatives/exchanges                                      |  [+]   |   [+]   | 
| /derivatives/exchanges/{id}                                 |  [+]   |   [+]   | 
| /derivatives/exchanges/list                                 |  [+]   |   [+]   |

|           Status Updates Endpoints                          | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /status_updates                                             |  [+]   |   [+]   | 

|           Events Endpoints                                  | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /events                                                     |  [+]   |   [+]   | 
| /events/countries                                           |  [+]   |   [+]   | 
| /events/types                                               |  [+]   |   [+]   | 

|           Exchange Rates Endpoints                          | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /exchange_rates                                             |  [+]   |   [+]   | 

|           Trending Endpoints                                | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /search/trending                                            |  [-]   |   [-]   |

|           Global Endpoints                                  | Status | Testing | 
| :-----------------------------:                             | :----: | :-----: | 
| /global                                                     |  [+]   |   [+]   | 
| /global/decentralized_finance_defi                          |  [+]   |   [+]   | 


## Donations
Donations are greatly appreciated and a motivation to keep improving.

**BTC**:  1Czb4Z4Xj2rmvpN8YuNMc6dr7XNFuYQF5J

