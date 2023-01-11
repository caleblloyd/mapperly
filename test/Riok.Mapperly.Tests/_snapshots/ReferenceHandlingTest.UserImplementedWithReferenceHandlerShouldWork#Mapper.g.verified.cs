﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial B Map(A a)
    {
        return MapToB(a, new Riok.Mapperly.Abstractions.ReferenceHandling.Internal.PreserveReferenceHandler());
    }

    private B MapToB(A source, Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<A, B>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new B();
        refHandler.SetReference<A, B>(source, target);
        target.Parent = MapToB(source.Parent, refHandler);
        target.Value = MapToD(source.Value, refHandler);
        return target;
    }

    private D MapToD(C source, Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<C, D>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new D();
        refHandler.SetReference<C, D>(source, target);
        target.StringValue = ToStringMod(source.StringValue, refHandler);
        return target;
    }
}