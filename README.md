# Game-TP

## Visão geral ✅

Projeto de jogo em Unity com foco em implementação em C#. Este repositório demonstra organização de projeto, scripts em C#, edição personalizada no editor Unity e uso de assets (gráficos, sons e prefabs), sendo um ótimo case para um desenvolvedor **C#/.NET full-stack** 

---

## Tecnologias e ferramentas 🔧

- **Linguagem:** C# (scripts Unity, editor scripts)
- **Engine:** Unity (versão especificada em `ProjectSettings/ProjectVersion.txt` - atualmente 2018.3.0f2)
- **IDE / workflow:** Arquivos `.sln` e `.csproj` (compatível com Visual Studio / Rider)
- Estrutura de Assets (Prefabs, Scenes, Scripts, Sounds, Graphics)

---

## Pontos fortes para um desenvolvedor C#/.NET completo 💡

- **Programação orientada a objetos (C#):** scripts e componentes demonstram prática com classes Unity (`MonoBehaviour`) e padrões de separação de responsabilidades.
- **Ferramentas e automações do Editor:** há scripts de editor (`Assets/Editor`) mostrando conhecimento na extensão do workflow do Unity (ex.: autosave antes de entrar em Play Mode) — útil para desenvolvedores que implementam ferramentas internas.
- **Arquitetura modular de assets:** uso de prefabs e pastas bem organizadas facilita manutenção, versionamento e integração contínua de artefatos.
- **Integração com o ecossistema .NET:** solução (`.sln`) e projetos C# permitem uso de boas práticas de engenharia, debugs no IDE e integração com frameworks e bibliotecas .NET quando necessário.
- **Pipeline de build e configurações:** arquivos em `ProjectSettings` e `Assembly-CSharp*.csproj` indicam pontos de integração para build automatizado e CI (ex.: GitHub Actions, Azure Pipelines).
- **Oportunidades para backend e serviços:** fácil extensão para integrar serviços (telemetria, APIs REST com ASP.NET Core, leaderboards, etc.), permitindo um desenvolvedor full-stack atuar no front (jogo) e no backend.

---

## Estrutura relevante do repositório 📁

- `Assets/Scripts/` — lógica de jogo (C#)
- `Assets/Editor/` — scripts que estendem o editor Unity
- `Assets/Grid/`, `Assets/Graphics/`, `Assets/Sounds/` — organização de conteúdo de jogo
- `ProjectSettings/` — configuração do projeto Unity (versões, input, qualidade)
- `Assembly-CSharp.csproj` / `Jogo.sln` — solução C# para desenvolvimento em IDE

---

## Como rodar ▶️

1. Abra o projeto com Unity (versão indicada em `ProjectSettings/ProjectVersion.txt`).
2. Abra a solução `Jogo.sln` em Visual Studio ou Rider para edição e debugging dos scripts C#.
3. Para contribuir: crie uma branch, modifique scripts, adicione testes (Unity Test Runner ou frameworks compatíveis) e abra um pull request.

