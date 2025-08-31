devlog: (bisi poho)
<sup>August 31, 2025 — Add Life Cycles (Commit: afcae3d)</sup>

<sub><b>Introduced robust screen and scene lifecycle management via:</b></sub>

<sub>VNGSceneManager<T>: handles pushing, destroying, updating, and rendering of screens
VNGScreenManager: defines lifecycle hooks like `screenDidAppear`, `runtimeUpdate`, with safeguards preventing misuse of view and device outside allowed stages</sub>

<sub><b>Added core scene components:</b></sub>

<sub>`VNGComponent`, `VNGContainer blueprint`, `VNGText` for composable UI building (Not yet there)</sub>

<sub><b>Sample implementations:</b></sub>

<sub>`MainMenu` and `UserSettingMenu screens`</sub>
<sub>`VNGGame` now orchestrates scene manager lifecycle and initial screen load</sub>

<sub>Overall cleanup: removed redundant code, fixed boilerplate, addressed possible crashes and improved string handling</p></sub>
