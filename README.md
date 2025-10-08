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
/Assets/Art          # Submodule: shared art assets
/Assets/Audio        # Submodule: shared audio assets
/Packages            # External and custom Unity packages
/ProjectSettings     # Unity project settings (version, quality, etc.)
/Builds              # Output builds (ignored in git)
/Tools               # Editor and CLI tools for development
/Docs                # Documentation and guidelines
```

---

## Requirements

* Unity Editor: 2022.3 LTS (or as specified in `ProjectSettings`)
* Git (with submodule support, and LFS if applicable)
* Rider, Visual Studio, or VS Code
* Platform SDKs (as needed per project: iOS, Android, WebGL, etc.)

---

## Getting Started

1. Clone the repository with submodules:

   ```bash
   git clone --recursive https://github.com/dareto-dream/gamestudio25-26.git
   cd gamestudio25-26
   ```

   If you already cloned without `--recursive`, initialize submodules:

   ```bash
   git submodule update --init --recursive
   ```

2. Open the project in Unity (ensure you're using the correct version).

3. Restore any dependencies via the Unity Package Manager.

4. Build or run the game from the editor or using the provided build tools.

---

## Submodules

This project uses Git submodules for large or shared resources:

* **Assets/Art** → External repository for 2D/3D art assets.
* **Assets/Audio** (optional) → External repository for sound effects, music, or voice acting.

To update submodules to their latest remote version:

```bash
git submodule update --remote --merge
```

---

## Contributing

All contributions should follow the internal Mid-Pacific development guidelines:

* Use feature branches (`feature/`, `fix/`, `tooling/`)
* Write clear commit messages
* Include documentation for new systems
* Run all pre-commit tests and validations

Please review the [CONTRIBUTING.md](./Docs/CONTRIBUTING.md) file for detailed contribution policies and workflows.

---

## Documentation

* [Development Guide](./Docs/development.md)
* [Coding Standards](./Docs/code-style.md)
* [Build Pipeline](./Docs/build.md)
* [Tooling Overview](./Docs/tools.md)

---

## License

This project is licensed under the [Apache License 2.0](./LICENSE).

© 2025–2026 Mid-Pacific Institute. All rights reserved.