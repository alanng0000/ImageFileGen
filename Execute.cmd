@echo off



cd Gen/bin/Debug/net6.0-windows


dotnet Gen.dll



if %ERRORLEVEL% NEQ 0 (
    echo Fail: Code %ERRORLEVEL%
)



cd ../../../..