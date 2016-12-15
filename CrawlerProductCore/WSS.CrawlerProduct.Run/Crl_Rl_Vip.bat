cd %~dp0
pushd %curdir%
start "W: Crl_Rl_Vip 50" WSS.CrawlerProduct.Run.exe -t 1 -nt 50 -QueueMq Vip.Cmp.Crl.Rl 