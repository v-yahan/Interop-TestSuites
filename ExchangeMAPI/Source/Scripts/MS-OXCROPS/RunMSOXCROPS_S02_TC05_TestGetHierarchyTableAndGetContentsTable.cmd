@echo off
pushd %~dp0
"%VS120COMNTOOLS%..\IDE\mstest" /test:Microsoft.Protocols.TestSuites.MS_OXCROPS.S02_FolderROPs.MSOXCROPS_S02_TC05_TestGetHierarchyTableAndGetContentsTable /testcontainer:..\..\MS-OXCROPS\TestSuite\bin\Debug\MS-OXCROPS_TestSuite.dll /runconfig:..\..\MS-OXCROPS\MS-OXCROPS.testsettings /unique
pause