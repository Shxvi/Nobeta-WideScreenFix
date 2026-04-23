# Little Witch Nobeta - Widescreen & Resolution Fix

A BepInEx plugin for **Little Witch Nobeta** that forces the game to run at your monitor's native resolution and fixes the aspect ratio for 16:10, 21:9, and other non-16:9 displays.

## 🌟 Features
* Forces the game to use your native display resolution (e.g., 2560x1600, 3440x1440).
* Adjusts the game's UI to ensure elements aren't cropped or stretched.

---

| Original 16:10 (Black Bars) | 16:10 (Fixed) |
| :---: | :---: |
| <img width="2560" height="1600" alt="20260423133445_1" src="https://github.com/user-attachments/assets/a349dd2c-1b35-45f5-b112-2fd9821d8903" /> | <img width="2560" height="1600" alt="20260423125055_1" src="https://github.com/user-attachments/assets/211810b3-0f61-4b0f-8fd5-b055f6ed34b9" />

---

## 🛠 Installation

1. **Install BepInEx (IL2CPP)**:
   * Download the latest [BepInEx Bleeding Edge](https://builds.bepinex.dev/projects/bepinex_be) for IL2CPP.
   * Extract the contents into your game's root folder (`steamapps/common/Little Witch Nobeta`).
   * Run the game once to let BepInEx initialize, then close the game.

2. **Install the Plugin**:
   * Go to the [Releases](https://github.com/Shxvi/Nobeta-WideScreenFix/releases) page.
   * Download the `WideScreenFix.dll`.
   * Place the `.dll` file into the `BepInEx/plugins` folder.

3. **Launch the Game**:
   * The mod will automatically detect your resolution and apply the fix upon startup.

---

## 🖥 Build 

1. Clone the repository:
   ```
   git clone https://github.com/Shxvi/Nobeta-WideScreenFix.git

2. Open the solution in Visual Studio 2022.

3. Ensure the Target Framework is set to .NET Standard 2.1.

4. Build the solution in Release mode.

## 🤝 Contributing
This is my first modding project! If you encounter any bugs or have suggestions for improving the code (especially the IL2CPP build pipeline), feel free to open an issue or a pull request.

## 📄 License
This project is licensed under the MIT License.
