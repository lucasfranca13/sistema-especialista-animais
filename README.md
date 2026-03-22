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

### Pré-requisitos
Certifique-se de ter instalado em sua máquina:
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)

### ⚙️ 1. Configurando e Rodando o Backend (API C#)

Abra o terminal na raiz do projeto e navegue até a pasta do backend:

```bash
cd backend
```

Restaure as dependências e crie o banco de dados SQLite com as regras. Para isso, abra o termial da IDE e execute os seguitens comandos:

```bash
dotnet restore
dotnet ef database update
```

Inicie o servidor da API. Também no terminal, execute o comando:

```bash
dotnet run
```
> **Aviso:** A API ficará rodando (geralmente na porta `https://localhost:7273`). Deixe este terminal aberto.

### 💻 2. Configurando e Rodando o Frontend

Abra um **novo terminal** na raiz do projeto (mantendo o do backend aberto) e navegue até a pasta do frontend:

```bash
cd frontend
```

Instale as dependências do Node:

```bash
npm install
```

Inicie o servidor de desenvolvimento do React:

```bash
npm run dev
```
> **Acesso:** O terminal mostrará um link local (geralmente `http://localhost:5173`). Clique nele ou cole no seu navegador para utilizar o sistema.

---
