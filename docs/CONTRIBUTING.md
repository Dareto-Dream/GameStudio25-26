# Contributing Guide

Thank you for contributing to **GameStudio (2025–2026)**.  
This document explains the workflow, coding standards, and collaboration rules for this repository.

---

## Repository Setup

### Clone with Submodules
This project uses Git submodules for art and audio assets.  
When cloning for the first time, use:

```bash
git clone --recursive https://github.com/dareto-dream/gamestudio25-26.git
cd gamestudio25-26
````

If you already cloned without `--recursive`:

```bash
git submodule update --init --recursive
```

### Updating Submodules

To pull the latest changes from submodules:

```bash
git submodule update --remote --merge
```

* **`Assets/Art`** → external repository for 2D/3D art assets
* **`Assets/Audio`** (optional) → external repository for sound, music, and voice acting

---

## Branching Model

We use a lightweight GitFlow-inspired workflow:

* **`main`** → stable branch (always buildable)
* **`develop`** → integration branch for upcoming features
* **feature/** → new gameplay mechanics, tools, or systems
* **fix/** → bug fixes
* **tooling/** → CI/CD, pipeline, or editor tooling updates

Example branch names:

* `feature/rhythm-controller`
* `fix/audio-sync`
* `tooling/build-pipeline`

---

## Commit Guidelines

* Use present tense, imperative style:

  * `Add note hit detection logic`
  * `Fix input lag in puppeteer mode`
* Keep messages clear and concise.
* Reference issues when applicable:

  * `Improve chart parser (closes #42)`

---

## Unity Project Standards

1. **Unity Version**
   Always use the version defined in `ProjectSettings/ProjectVersion.txt` (2022.3 LTS).

2. **Folder Structure**
   Keep Unity’s folder hierarchy consistent:

   ```
   /Assets
     /Art        # Linked submodule
     /Audio      # Linked submodule (optional)
     /Scenes
     /Scripts
     /Prefabs
     /UI
   ```

3. **Naming Conventions**

   * Scripts → PascalCase (e.g., `NoteHandler.cs`)
   * Folders → PascalCase
   * Variables → camelCase
   * Constants → ALL_CAPS

4. **Scenes**

   * Store all scenes in `/Assets/Scenes`.
   * Use descriptive names (e.g., `MainMenu.unity`, `Level_01.unity`).

5. **Prefabs**

   * All prefabs go into `/Assets/Prefabs`.
   * Reuse prefabs whenever possible to reduce duplication.

---

## Testing and Validation

Before pushing changes:

1. Ensure the project builds in Unity without errors.
2. Run all available playtests for your feature or scene.
3. Validate new code against the [Coding Standards](./code-style.md).
4. If applicable, add documentation in `/Docs`.

---

## Documentation

* Update `/Docs` whenever you add or modify core systems.
* Use Markdown for readability.
* Include diagrams or screenshots if they improve clarity.

---

## Code Reviews

* Open a Pull Request (PR) into `develop` when ready.
* At least one reviewer must approve before merging.
* Keep PRs focused (one feature or fix per PR).

---

## Release Process

1. Ensure `develop` is stable and tested.
2. Open a PR into `main`.
3. Tag the release (`v1.0.0`, `v1.1.0`, etc.).
4. CI/CD will handle builds (if configured).

---

## License

By contributing, you agree that your contributions are licensed under the [Apache License 2.0](../LICENSE).