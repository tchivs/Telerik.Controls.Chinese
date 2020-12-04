# Telerik.Controls.Chinese

Telerik WPF 控件汉化包

## 使用方法：

引用```Telerik.Controls.Chinese```包后在App的静态构造方法中添加以下代码即可

```C#
 static App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            LocalizationManager.Manager = new ChineseLocalizationManager();
        }

```