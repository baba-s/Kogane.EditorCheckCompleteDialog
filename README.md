# Kogane Editor Check Complete Dialog

EditorUtility.DisplayDialog で確認と完了のダイアログを表示するクラス

## 使用例

```csharp
using Kogane;
using UnityEditor;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    public static void Hoge()
    {
        var dialog = new EditorCheckCompleteDialog( "タイトル", "ダイアログを表示" );

        if ( !dialog.OpenCheck() ) return;

        dialog.OpenComplete();
    }
}
```

```csharp
using Kogane;
using UnityEditor;

public static class Example
{
    private static readonly EditorCheckCompleteDialogCreator m_creator = new( "タイトル" );

    [MenuItem( "Tools/Hoge" )]
    public static void Hoge()
    {
        var dialog = m_creator.Create( "Hoge ダイアログを表示" );

        if ( !dialog.OpenCheck() ) return;

        dialog.OpenComplete();
    }

    [MenuItem( "Tools/Foo" )]
    public static void Foo()
    {
        var dialog = m_creator.Create( "Foo ダイアログを表示" );

        if ( !dialog.OpenCheck() ) return;

        dialog.OpenComplete();
    }
}
```