@echo off
echo 正在编译 NCat批量Telnet工具...

REM 检查是否有 MSBuild
set MSBUILD_PATH=
for /f "usebackq tokens=*" %%i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -latest -requires Microsoft.Component.MSBuild -find MSBuild\**\Bin\MSBuild.exe 2^>nul`) do (
    set MSBUILD_PATH=%%i
)

if "%MSBUILD_PATH%"=="" (
    echo 未找到 MSBuild，尝试使用 .NET Framework 4.5 的 MSBuild...
    set MSBUILD_PATH=%windir%\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe
)

if not exist "%MSBUILD_PATH%" (
    echo 错误：未找到 MSBuild！请安装 Visual Studio 或 .NET Framework 4.5 开发工具包。
    pause
    exit /b 1
)

echo 使用 MSBuild: %MSBUILD_PATH%
"%MSBUILD_PATH%" NCatTelnetTool.csproj /p:Configuration=Release /v:minimal

if %ERRORLEVEL% EQU 0 (
    echo.
    echo 编译成功！
    echo 输出文件位于: bin\Release\NCatTelnetTool.exe
) else (
    echo.
    echo 编译失败！
)

pause
