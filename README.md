# FlatUI

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/evilon2000/FlatUI/blob/main/LICENSE)
[![.NET](https://github.com/evilon2000/FlatUI/actions/workflows/dotnet.yml/badge.svg)](https://github.com/evilon2000/FlatUI/actions/workflows/dotnet.yml)

FlatUI 是一个用 C# 编写的扁平化（Flat）风格 UI 组件库，专为 Windows Forms 应用程序设计。它提供了一系列现代、简洁的自定义控件，支持平滑的视觉效果和交互响应，帮助开发者快速构建美观的桌面界面。

## 特性

- **扁平设计**：简约的颜色方案和无边框风格，符合现代 UI 趋势。
- **丰富的控件**：包括按钮、文本框、复选框、进度条等常见组件。
- **易于集成**：直接在 Visual Studio 中引用，支持 .NET Framework。
- **自定义主题**：通过 `FlatColors` 和 `FlatColorPalette` 轻松调整颜色。

### 支持的组件

| 类别 | 组件 |
|------|------|
| 输入控件 | `FlatButton`、`FlatTextBox`、`FlatCheckBox`、`FlatRadioButton`、`FlatComboBox`、`FlatNumeric`、`FlatToggle`、`FlatListBox` |
| 显示与布局 | `FlatLabel`、`FlatGroupBox`、`FlatTabControl`、`FlatStatusBar`、`FlatProgressBar`、`FlatTrackBar`、`FlatTreeView` |
| 菜单与指示 | `FlatContextMenuStrip`、`FlatClose`、`FlatMax`、`FlatMini`、`FlatStickyButton` |
| 对话与通知 | `FlatAlertBox`、`FlatMessageBox` |
| 辅助 | `FormSkin`（表单皮肤）、`MouseState`（鼠标状态跟踪）、`Helpers`（工具方法） |

## 安装

1. **克隆仓库**：
   ```
   git clone https://github.com/evilon2000/FlatUI.git
   ```

2. **打开解决方案**：
   - 在 Visual Studio 中打开 `FlatUI.sln`。
   - 构建项目（Build > Build Solution），生成 `FlatUI.dll`。

3. **在你的项目中引用**：
   - 在你的 Windows Forms 项目中右键“引用” > “添加引用” > 浏览到生成的 DLL 文件。
   - 或通过 NuGet（未来版本支持）：
     ```
     Install-Package FlatUI
     ```

**要求**：.NET Framework 4.5 或更高版本。

## 使用示例

### 基本用法：添加一个 FlatButton

在你的 Form 构造函数或 Load 事件中：

```csharp
using FlatUI;  // 引入命名空间

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // 创建一个 FlatButton
        FlatButton myButton = new FlatButton();
        myButton.Text = "点击我";
        myButton.Size = new Size(100, 30);
        myButton.Location = new Point(50, 50);
        myButton.BackColor = FlatColors.Primary;  // 使用预定义颜色

        // 添加事件
        myButton.Click += (sender, e) => {
            MessageBox.Show("按钮被点击了！");
        };

        this.Controls.Add(myButton);
    }
}
```

### 应用表单皮肤

使用 `FormSkin` 为整个表单应用扁平风格：

```csharp
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        FormSkin.ApplySkin(this);  // 应用扁平皮肤
    }
}
```

### 自定义颜色

```csharp
FlatColorPalette.Custom = new Color[] { Color.FromArgb(52, 152, 219), Color.FromArgb(41, 128, 185) };  // 自定义调色板
```

更多示例请查看仓库中的测试项目（未来添加）。

## 文档

- [颜色方案](docs/colors.md)（计划中）
- [控件 API](docs/api.md)（计划中）

## 贡献

欢迎贡献！请遵循以下步骤：

1. Fork 本仓库。
2. 创建一个新分支（`git checkout -b feature/新功能`）。
3. 提交你的更改（`git commit -am '添加新功能'`）。
4. Push 到分支（`git push origin feature/新功能`）。
5. 创建 Pull Request。

请确保代码通过构建测试，并添加单元测试。

## 许可证

此项目采用 [MIT 许可证](LICENSE)。查看 [LICENSE](LICENSE) 文件以获取详情。

## 联系

- 作者：evilon2000
- GitHub Issues：用于报告 bug 或提出功能请求。

感谢使用 FlatUI！如果有问题，欢迎在 Issues 中讨论。🚀
