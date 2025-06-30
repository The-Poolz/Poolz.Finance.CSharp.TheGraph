using GraphQlClientGenerator;

namespace Poolz.Finance.CSharp.TheGraph.Generator;

public sealed class ScalarFieldTypeMappingProvider : IScalarFieldTypeMappingProvider
{
    public ScalarFieldTypeDescription GetCustomScalarFieldType(ScalarFieldTypeProviderContext context)
    {
        var unwrapped = context.FieldType.UnwrapIfNonNull();

        return unwrapped.Name switch
        {
            "BigInt" => new ScalarFieldTypeDescription
            {
                NetTypeName = GenerationContext.GetNullableNetTypeName(context, "System.Numerics.BigInteger", isReferenceType: false)
            },
            "Bytes" => new ScalarFieldTypeDescription
            {
                NetTypeName = GenerationContext.GetNullableNetTypeName(context, "string", isReferenceType: true)
            },
            _ => DefaultScalarFieldTypeMappingProvider.GetFallbackFieldType(context)
        };
    }
}