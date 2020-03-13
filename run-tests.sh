#!/bin/sh

 dotnet test --logger 'trx;LogFileName=TestResults.trx' --logger 'xunit;LogFileName=TestResults.xml' --results-directory ./calculatorLibrary.Tests/BuildReports/UnitTests  /p:CollectCoverage=true /p:CoverletOutput=BuildReports/Coverage/ /p:CoverletOutputFormat=cobertura /p:Exclude='[xunit.*]*'
echo 'generating reports'
 ./tools/reportgenerator -reports:./calculatorLibrary.Tests/BuildReports/Coverage/coverage.cobertura.xml -targetdir:./calculatorLibrary.Tests/BuildReports/Coverage -reporttypes:"HTML;HTMLSummary"

                 
                 
