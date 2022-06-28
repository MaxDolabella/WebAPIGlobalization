
# Como usar Globalization

## Em `Program.cs`

Adicionar:
```csharp 
builder.Services.AddLocalization();
```

Configurar:
``` csharp
var supportedCultures = new[] { "pt-BR", "en-US", "it", "zh-CN" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);```



