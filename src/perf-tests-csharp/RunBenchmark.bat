@echo off
set /p id="Which benchmark should I run ?: "
cd .\bin\Release\
perf-tests-csharp.exe Benchmark%id%
pause