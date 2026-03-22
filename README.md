# 🐾 Sistema Especialista: Identificação de Animais

![Status](https://img.shields.io/badge/Status-Concluído-success)
![Stack Backend](https://img.shields.io/badge/Backend-C%23_.NET_8-512BD4)
![Stack Frontend](https://img.shields.io/badge/Frontend-React_Vite-61DAFB)
![Database](https://img.shields.io/badge/Database-SQLite-003B57)

Trabalho prático da disciplina de **Inteligência Artificial** do curso de Sistemas de Informação (Faculdade Cotemig).

Este projeto é um **Sistema Especialista** baseado em regras que utiliza o método de **Encadeamento para Frente (Forward Chaining)**. O sistema atua como um "Akinator Biológico": a partir de características informadas pelo usuário, o motor de inferência deduz qual animal está sendo pensado, aplicando lógicas e exibindo todo o raciocínio passo a passo.

## 🏗️ Arquitetura e Organização

O repositório está estruturado em um *Monorepo*, separando claramente as responsabilidades:

- 📁 **`backend/`**: API RESTful em C# (.NET) responsável pelo Motor de Inferência, Base de Conhecimento (SQLite) e validação lógica.
- 📁 **`frontend/`**: Aplicação Web Single Page (SPA) em React e Tailwind CSS, responsável por uma interface interativa e amigável.

## ✨ Principais Funcionalidades

1. **Motor de Inferência Puro:** Algoritmo C# que processa as regras ciclicamente até esgotar as deduções possíveis.
2. **Prevenção de Conflitos (Trava Lógica):** O backend identifica "Frankensteins" biológicos. Se o usuário informar características incompatíveis (ex: Ave e Mamífero simultaneamente), o sistema barra a inferência nativamente e retorna um erro de domínio lógico.
3. **Motor de Explicação:** A interface exibe exatamente a trilha do raciocínio, justificando como a conclusão foi alcançada.
4. **Base Consistente (25 Animais):** Base de conhecimento robusta dividida em 5 classes biológicas primárias (Mamíferos, Aves, Répteis, Anfíbios e Peixes) sem ambiguidades.

## 🚀 Como Executar o Projeto (Passo a Passo)

Para rodar o projeto localmente, você precisará do [Node.js](https://nodejs.org/) e do [.NET 8 SDK](https://dotnet.microsoft.com/download) instalados na sua máquina.

Faça o clone do repositório:
```bash
git clone [https://github.com/SeuUsuario/NomeDoRepositorio.git](https://github.com/SeuUsuario/NomeDoRepositorio.git)
cd NomeDoRepositorio
