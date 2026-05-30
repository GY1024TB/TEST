# NCat批量Telnet工具

基于.NET Framework 4.5开发的GUI批量Telnet工具，使用ncat进行连接管理。

## 功能特性

- 批量连接管理：支持同时管理多个Telnet连接
- 单独/批量连接：可以选择单个连接或全部连接进行连接
- 终端交互：支持实时显示终端输出
- 命令代理：支持预设常用命令并使用中文名称
- 批量命令下发：支持向所有连接发送相同命令
- 命令输入：支持直接输入命令，按回车发送

## 系统要求

- Windows 7 或更高版本
- .NET Framework 4.5
- ncat（需要放在系统PATH或程序目录下）

## 编译方法

### 使用 Visual Studio

1. 打开 `NCatTelnetTool.csproj`
2. 选择 Release 配置
3. 点击生成解决方案

### 使用 MSBuild 命令行

```bash
msbuild NCatTelnetTool.csproj /p:Configuration=Release
```

## 使用说明

1. 启动程序
2. 点击"添加连接"按钮，添加需要连接的主机
3. 选择一个或多个连接，点击"连接选中"或"连接全部"
4. 在命令输入框中输入命令，点击"发送到选中"或"发送到全部"
5. 双击命令代理列表中的项可以快速填入预设命令

## 注意事项

- 需要系统安装ncat工具
- 确保目标主机的Telnet端口（默认为23）已开放
