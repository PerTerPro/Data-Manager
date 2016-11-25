cd %~dp0
pushd %curdir%
start "P: PushProductIdCurrentToRedis" WSS.ImageServer.Service.exe -cmd PushProductIdCurrentToRedis