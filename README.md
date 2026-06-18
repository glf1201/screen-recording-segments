# Recorder / 值守录屏工具

Windows unattended screen recording tool built with `C#`, `.NET 8`, `WPF`, and `FFmpeg`.

基于 `C#`、`.NET 8`、`WPF` 和 `FFmpeg` 开发的 Windows 值守录屏工具。

## Overview / 项目简介

This project is designed for long-running desktop recording on Windows. It supports segmented recording, tray mode, auto-start, watchdog recovery, scheduled cleanup, and system-audio capture.

本项目用于 Windows 桌面长期值守录屏，支持分段录像、托盘驻留、开机启动、守护拉起、定时清理和系统声音采集。

## Features / 主要功能

- Segmented recording every 10 minutes with automatic file saving
- Uses WASAPI loopback to capture system audio and merge it into FFmpeg recording
- Supports auto-start with Windows and tray-only startup
- Includes `WatchDog` to restart the recorder if the main process exits unexpectedly
- Supports recording format, storage path, display target, and audio device configuration
- Supports scheduled cleanup for recording folders and up to 5 additional cleanup directories
- Supports exit password, single-instance activation, recent logs, and recent recordings

- 每 10 分钟自动切片录制并保存录像文件
- 通过 WASAPI loopback 回采系统声音，并与 FFmpeg 录屏合成
- 支持开机启动和静默驻留托盘
- 内置 `WatchDog` 守护程序，主进程异常退出后可自动拉起
- 支持录像格式、保存路径、显示器目标和音频设备配置
- 支持录像目录和最多 5 个附加目录的定时清理
- 支持退出密码、单实例唤起、最近日志和最近录像展示

## Screenshots / 界面截图

<img width="692" height="293" alt="Main Window" src="https://github.com/user-attachments/assets/4aee490c-17b6-42c8-a8db-333c9210a720" />

<img width="433" height="331" alt="Settings Window" src="https://github.com/user-attachments/assets/d726d921-e779-464a-a61d-49394aa8d2e2" />

## Tech Stack / 技术栈

- C#
- .NET 8
- WPF
- HandyControl
- FFmpeg
- NAudio

## Project Structure / 目录结构

- `src/RecorderApp` - Main desktop recorder application / 主录屏程序
- `src/WatchDog` - Watchdog process / 守护程序
- `images` - Application icons and UI assets / 图标和界面资源
- `Tools/ffmpeg/bin/ffmpeg.exe` - Recommended FFmpeg location / 推荐的 FFmpeg 放置位置

## Quick Start / 快速开始

1. Install `.NET 8 SDK` and the corresponding Windows Desktop Runtime.
2. Build or publish the solution on Windows 10/11.
3. Place `ffmpeg.exe` under `Tools/ffmpeg/bin/`, or let the application prepare it during first run if your setup supports it.
4. Start the app with `RecorderApp.exe` or the packaged launcher script.

1. 安装 `.NET 8 SDK` 和对应的 Windows Desktop Runtime。
2. 在 Windows 10/11 上编译或发布本解决方案。
3. 将 `ffmpeg.exe` 放到 `Tools/ffmpeg/bin/` 下，或在支持的环境中由程序首次运行时准备。
4. 通过 `RecorderApp.exe` 或打包后的启动脚本启动程序。

## Build / 构建

```bash
dotnet build RecorderSuite.sln -c Release
```

## Notes / 使用说明

- The default recording directory is `Record/` under the application folder.
- Recordings are stored by date folder, using filenames like `yyyy-MM-dd_HH-mm.ext`.
- The recorder can start automatically after launch and can remain in the system tray.
- Exit protection supports password verification before shutdown.
- Cleanup rules now delete old recording folders by directory instead of only deleting a limited number of files.

- 默认录像目录为程序目录下的 `Record/`。
- 录像按日期自动分目录保存，文件名格式为 `yyyy-MM-dd_HH-mm.ext`。
- 程序支持启动后自动录制，并可常驻系统托盘。
- 退出程序前可进行密码校验。
- 当前清理规则已改为按目录删除过期录像，而不是只删除有限数量的单个文件。

## Release Package / 发布包

- Packaged build output: `dist/Recorder.zip`
- Release page: GitHub Releases

- 打包产物：`dist/Recorder.zip`
- 发布页面：GitHub Releases
