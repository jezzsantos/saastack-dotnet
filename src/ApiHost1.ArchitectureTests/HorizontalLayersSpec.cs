using ArchitectureTesting.Common;
using Xunit;

namespace ApiHost1.ArchitectureTests;

[Trait("Category", "Unit.Architecture")]
[Collection("Architecture")]
public class HorizontalLayersSpec : HorizontalLayersSpecBase<Program>
{
    public HorizontalLayersSpec(ArchitectureSpecSetup<Program> setup) : base(setup)
    {
    }

    //TODO: add additional tests here
}