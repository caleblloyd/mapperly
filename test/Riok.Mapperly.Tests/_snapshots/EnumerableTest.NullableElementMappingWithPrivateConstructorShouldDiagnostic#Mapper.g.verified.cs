﻿//HintName: Mapper.g.cs
// <auto-generated />
#nullable enable
public partial class Mapper
{
    [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
    private partial global::B Map(global::A source)
    {
        var target = new global::B();
        target.Value = global::System.Linq.Enumerable.ToList(
            global::System.Linq.Enumerable.Select(
                source.Value,
                x => throw new System.NotImplementedException("Mapperly: Could not generate mapping")
            )
        );
        return target;
    }
}