using System.Runtime.CompilerServices;

namespace GenerateQuestPDF.Tests;

[UsesVerify]
public class PdfGenerator
{
    [ModuleInitializer]
    internal static void Init() =>
        VerifyQuestPdf.Initialize();

    [Fact]
    public Task Test1()
    {
        var document = GenerateQuestPDF.PdfGenerator.GenerateDocument();
        return Verify(document);
    }
}