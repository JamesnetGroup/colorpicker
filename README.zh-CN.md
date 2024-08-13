# ColorPicker [![英文](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/docs-中文-red.svg)](README.zh-CN.md) [![韩文](https://img.shields.io/badge/Language-한국어-green.svg)](README.ko.md)

一个面向开发者和设计师的实用工具，用于在 Windows 系统中捕获和操作颜色

[![许可证: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![星标](https://img.shields.io/github/stars/jamesnet214/colorpicker.svg)](https://github.com/jamesnet214/colorpicker/stargazers)
[![问题](https://img.shields.io/github/issues/jamesnet214/colorpicker.svg)](https://github.com/jamesnet214/colorpicker/issues)

## 项目概览

ColorPicker 是一个 Windows 操作系统上的实用程序，允许用户轻松捕获所需的颜色或通过组合颜色提取十六进制值。它是开发者和设计师经常使用的工具，从简单的程序到专业软件如 Photoshop、Illustrator、MS Office 以及像 Visual Studio 这样的 IDE 中都可以找到它的身影。

<img src="https://github.com/user-attachments/assets/37891327-e967-445e-b2ec-2bc9885b254e" width="49%"/>
<img src="https://github.com/user-attachments/assets/f8e136c0-7cfd-4990-bc4b-e3872138f908" width="49%"/>

## 关键技术与实现

#### 1. 自定义控件开发
- [x] 实现自定义 ColorWheel 和 ColorSlider 控件
- [x] WPF 渲染技术的高级应用

#### 2. MVVM 架构
- [x] 全面实现 MVVM 模式和数据绑定优化
- [x] 有效使用 RelayCommand 和 INotifyPropertyChanged 接口

#### 3. 高级 WPF 技术
- [x] 利用 Triggers 实现动态 UI 更新
- [x] 实现带虚拟化的自定义 ItemsControl
- [x] ControlTemplate 和 DataTemplate 的高级使用

#### 4. 颜色操作
- [x] 不同颜色空间（RGB、HSV、Hex）之间的实时颜色转换
- [x] 屏幕颜色捕获功能

#### 5. 性能优化
- [x] 高效渲染色轮和滑块
- [x] 即使在快速颜色变化时也能保持流畅的 UI 交互

## 技术栈
- .NET 8.0
- WPF (Windows Presentation Foundation)
- MVVM (Model-View-ViewModel) 模式

## 入门指南

### 前提条件
- Visual Studio 2022 或更高版本
- .NET 8.0 SDK

### 安装和执行

#### 1. 克隆仓库：
```
git clone https://github.com/jamesnet214/colorpicker.git
```

#### 2. 打开解决方案
- [x] Visual Studio
- [x] Visual Studio Code
- [x] Jetbrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 构建和运行
- [x] 推荐 Windows 11

## 使用方法
1. 启动 ColorPicker 应用程序
2. 使用色轮或滑块选择颜色
3. 使用吸管工具从屏幕上捕获颜色
4. 查看并复制所选颜色的十六进制、RGB 或 HSV 值

## 贡献
如果您想为改进项目做出贡献，请发送 Pull Request。我们欢迎任何形式的贡献！

## 许可证
本项目采用 MIT 许可证分发。有关更多详细信息，请参阅 [LICENSE](https://github.com/jamesnet214/colorpicker/blob/main/LICENSE) 文件。

## 联系方式
- 网站：https://jamesnet.dev
- 电子邮件：james@jamesnet.dev, vickyqu115@hotmail.com

使用 ColorPicker 探索颜色操作技术，并将其应用到您的项目中！
