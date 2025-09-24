# GameStudio (2025–2026)

**Mid-Pacific Game Development Studio**
Project Duration: 2025–2026

---

## Overview

GameStudio is the internal development environment for Mid-Pacific's 2025–2026 game projects. It includes tools, frameworks, templates, and pipelines for rapid prototyping and full game production. This repository serves as the foundation for all projects built within this cycle.

---

## Goals

* Standardize project structure and tooling across all teams.
* Enable efficient collaboration through shared frameworks and asset pipelines.
* Reduce ramp-up time for new team members and prototype initiatives.
* Maintain high code quality and performance benchmarks for release titles.

---

## Repository Structure

```
/Assets              # Unity assets: scenes, prefabs, scripts, etc.
/Packages            # External and custom Unity packages
/ProjectSettings     # Unity project settings (version, quality, etc.)
/Builds              # Output builds (ignored in git)
/Tools               # Editor and CLI tools for development
/Docs                # Documentation and guidelines
```

---

## Requirements

* Unity Editor: 2022.3 LTS (or as specified in `ProjectSettings`)
* Git (with LFS, if applicable)
* Rider, Visual Studio, or VS Code
* Platform SDKs (as needed per project: iOS, Android, WebGL, etc.)

---

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/dareto-dream/gamestudio25-26.git
   cd gamestudio25-26
   ```

2. Open the project in Unity (ensure you're using the correct version).

3. Restore any dependencies via Unity Package Manager.

4. Build or run the game from the editor or using provided build tools.

---

## Contributing

All contributions should follow the internal Mid-Pacific development guidelines:

* Use feature branches (`feature/`, `fix/`, `tooling/`)
* Write clear commit messages
* Include documentation for new systems
* Run all pre-commit tests and validations

Please review the [CONTRIBUTING.md](./CONTRIBUTING.md) file for more details.

---

## Documentation

* [Development Guide](./Docs/development.md)
* [Coding Standards](./Docs/code-style.md)
* [Build Pipeline](./Docs/build.md)
* [Tooling Overview](./Docs/tools.md)

---

## License

This repository is proprietary and intended for use by Mid-Pacific development teams only.
© 2025–2026 Mid-Pacific Institute. All rights reserved.