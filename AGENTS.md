# Fork contributor guidance

This is the iXab3r MAUI fork on `feature/dispatcher-recovery`. Work against the task's named fork branch/revision; upstream instructions to always target `main` describe upstream contribution, not permission to switch this fork's base. [README.md](README.md), [development guidance](.github/DEVELOPMENT.md), and [contributing guidance](.github/CONTRIBUTING.md) retain upstream context and attribution.

This branch is an older source snapshot with later owner changes. Inspect [global.json](global.json), `Directory.Build.*`, `build.*`, and the owning project's configuration for actual tool/workload requirements; do not replace them with today's stable SDK or feeds merely because old prose says "current stable". Upstream release/news links do not establish this fork's support, build status, or release artifacts.

`src/Core/src/Dispatching/` contains shared and platform-specific dispatchers; its unit/device tests live under `src/Core/tests/`. For dispatcher changes, inspect all affected platform partials and preserve thread affinity, queue ownership, callback/timer lifecycle, and target-platform behavior. A unit-test or compile pass on one host does not qualify the other platforms.

Use the repository build entry points and the narrowest relevant project/tests after inspecting prerequisites; report exact platforms and checks actually run. Documentation-only changes need factual consistency, local links, and diff checks with unrun code/device checks disclosed. Do not install workloads, update dependencies, launch devices, run autoformatters, or publish artifacts merely to validate prose. Preserve upstream [license](LICENSE.txt) and notices.

## Independent architecture and review

Start each delegated architect, advisor, and reviewer with empty conversation context (`fork_turns="none"` with `spawn_agent`, or the host's equivalent). Provide only the concrete question, repository path and relevant revisions, scope, constraints, and raw evidence locations. Keep the brief focused on the actual topic; omit the author's reasoning, preferred verdict, and earlier agents' conclusions.

Each agent independently inspects the relevant code, contracts, and platform evidence and reports its own evidence, conclusions, and uncertainty. The final reviewer must be separate from the implementer and design advisor, remain read-only, and inspect the final diff at the named revision. Disclose unavailable independent review rather than presenting self-review as independent.
