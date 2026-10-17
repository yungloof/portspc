@echo off
chcp 65001 >nul
title PORTSPC - Catalogo e Instalador Sob Demanda (PT-BR)
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "%~dp0scripts\portspc.ps1"
