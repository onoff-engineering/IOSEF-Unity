# Contributing to this repository

## Getting started

This Repo has Continuous Integration (workflow) scripts attached using GitHub Actions. 
* This allows it to automatically track and update the CHANGELOG based on what **commit** messages are given with new pushes to master.
* Development work on the provided Samples Assets are automatically renamed when deployed in this CI Pipeline to the **`upm`** branch.
* This **`upm`** branch is then automatically tagged and released once significant changes have been made, allowing for future clones of the Repo to be on the latest versions.

## Commit Message Formatting
In order to adhere to this Semantic Release automation, commit messages should be in the following format.
(The scope is an optional field to describe the related sub-system, which can be ignored)

### Format
```
<type>(<scope>): <subject>
```

### Types
```
breaking: change that alters core functionality
revert:   reverting to a commit/change to how it was previously
feat:     new feature
fix:      bug fix
perf:     code change that improves performance
test:     adding missing or correcting existing tests
refactor: code change that neither fixes a bug nor adds a feature
style:    changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)
docs:     documentation only changes
chore:    changes to the build process or auxiliary tools and libraries such as documentation generation
```

### Examples
```
feat: create dynamic group based on settings
fix: memory leak on mobile
docs: add badges to README
chore(release): 0.5.0
```
