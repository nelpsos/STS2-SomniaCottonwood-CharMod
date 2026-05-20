using BaseLib.Abstracts;
using SomniaCottonwood.SomniaCottonwoodCode.Extensions;
using Godot;

namespace SomniaCottonwood.SomniaCottonwoodCode.Character;

public class SomniaCottonwoodRelicPool : CustomRelicPoolModel
{
    public override Color LabOutlineColor => SomniaCottonwood.Color;

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();
}