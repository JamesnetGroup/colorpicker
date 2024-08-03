# ColorPicker [![English](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![한국어](https://img.shields.io/badge/Language-한국어-red.svg)](README.ko.md)

Windows에서 색상을 캡처하고 조작할 수 있는 개발자와 디자이너를 위한 실용적인 유틸리티

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![Stars](https://img.shields.io/github/stars/jamesnet214/colorpicker.svg)](https://github.com/jamesnet214/colorpicker/stargazers)
[![Issues](https://img.shields.io/github/issues/jamesnet214/colorpicker.svg)](https://github.com/jamesnet214/colorpicker/issues)

## 프로젝트 개요
ColorPicker는 Windows 운영 체제용 유틸리티 프로그램으로, 사용자가 원하는 색상을 쉽게 캡처하거나 색상을 조합하여 Hex 값을 추출할 수 있게 해줍니다. 이는 간단한 프로그램부터 Photoshop, Illustrator, MS Office, Visual Studio와 같은 전문 소프트웨어에 이르기까지 다양한 애플리케이션에서 개발자와 디자이너가 자주 사용하는 도구입니다.

<img src="https://github.com/user-attachments/assets/37891327-e967-445e-b2ec-2bc9885b254e" width="49%"/>
<img src="https://github.com/user-attachments/assets/f8e136c0-7cfd-4990-bc4b-e3872138f908" width="49%"/>

## 핵심 기술 및 구현 사항
#### 1. 커스텀 컨트롤 개발
- [x] 커스텀 ColorWheel 및 ColorSlider 컨트롤 구현
- [x] WPF 렌더링 기술의 고급 활용

#### 2. MVVM 아키텍처
- [x] MVVM 패턴의 완전한 구현 및 데이터 바인딩 최적화
- [x] RelayCommand 및 INotifyPropertyChanged 인터페이스의 효과적인 사용

#### 3. 고급 WPF 기술
- [x] 동적 UI 업데이트를 위한 Trigger 활용
- [x] 가상화를 적용한 커스텀 ItemsControl 구현
- [x] ControlTemplate 및 DataTemplate의 고급 사용법

#### 4. 색상 조작
- [x] 다양한 색상 공간(RGB, HSV, Hex) 간의 실시간 색상 변환
- [x] 화면 색상 캡처 기능

#### 5. 성능 최적화
- [x] 색상 휠 및 슬라이더의 효율적인 렌더링
- [x] 빠른 색상 변경에도 부드러운 UI 상호작용

## 기술 스택
- .NET 8.0
- WPF (Windows Presentation Foundation)
- MVVM (Model-View-ViewModel) 패턴

## 시작하기
### 필요 조건
- Visual Studio 2022 이상
- .NET 8.0 SDK

### 설치 및 실행
#### 1. 리포지토리 클론:
```
git clone https://github.com/jamesnet214/colorpicker.git
```
#### 2. 솔루션 열기
- [x] Visual Studio
- [x] Visual Studio Code
- [x] Jetbrains Rider

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="32%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="32%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="32%"/>

#### 3. 빌드 및 실행
- [x] Windows 11 권장

## 사용 방법
1. ColorPicker 애플리케이션 실행
2. 색상 휠이나 슬라이더를 사용하여 색상 선택
3. 스포이트 도구를 사용하여 화면에서 색상 캡처
4. 선택한 색상의 Hex, RGB 또는 HSV 값 확인 및 복사

## 기여하기
프로젝트 개선에 기여하고 싶으시다면 Pull Request를 보내주세요. 모든 형태의 기여를 환영합니다!

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](https://github.com/jamesnet214/colorpicker/blob/main/LICENSE) 파일을 참조하세요.

## 연락처
- 웹사이트: https://jamesnet.dev
- 이메일: james@jamesnet.dev, vickyqu115@hotmail.com

ColorPicker로 색상 조작 기술을 탐험하고 여러분의 프로젝트에 적용해보세요!
