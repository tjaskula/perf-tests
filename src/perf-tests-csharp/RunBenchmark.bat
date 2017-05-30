@echo off
set /p id="Which benchmark should I run ?: "
.\bin\Release\perf-tests-csharp.exe Benchmark%id%
pause