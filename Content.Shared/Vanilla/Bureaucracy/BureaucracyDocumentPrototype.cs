using Robust.Shared.Prototypes;
using Content.Shared.Verbs;

namespace Content.Shared.Vanilla.Bureaucracy;

[Serializable, Prototype("BureaucracyDocument")]
public sealed class BureaucracyDocumentPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; } = default!;

    [DataField]
    public string label { get; set; } = "WTF";

    [DataField]
    public string Text { get; set; } = "";

    [DataField]
    public int Priority { get; set; } = 0;
    
    [DataField]
    public string Category { get; set; } = "";

    public VerbCategory GetCategory()
    {
        // Пытаемся преобразовать строку в VerbCategory
        return Category switch
        {
            "Order" => VerbCategory.BureaucracyOrder,
            "Report" => VerbCategory.BureaucracyReports,
            "Request" => VerbCategory.BureaucracyRequest,
            _ => VerbCategory.Bureaucracy
        };
    }

}