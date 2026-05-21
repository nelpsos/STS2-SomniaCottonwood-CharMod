using BaseLib.Abstracts;
using SomniaCottonwood.SomniaCottonwoodCode.Extensions;
using Godot;

namespace SomniaCottonwood.SomniaCottonwoodCode.Character;

public class SomniaCottonwoodCardPool : CustomCardPoolModel
{
    public override string Title => SomniaCottonwood.CharacterId;
    public override string EnergyColorName => SomniaCottonwood.CharacterId;

    public override string BigEnergyIconPath => "charui/big_energy.png".ImagePath();
    public override string TextEnergyIconPath => "charui/text_energy.png".ImagePath();



    /* These HSV values will determine the color of your card back.
    They are applied as a shader onto an already colored image,
    so it may take some experimentation to find a color you like.
    Generally they should be values between 0 and 1. */
    public override float H => 0.244f; //Hue; changes the color.
    public override float S => 0.24f; //Saturation
    public override float V => 0.43f; //Brightness

    //Alternatively, leave these values at 1 and provide a custom frame image.
    /*public override Texture2D CustomFrame(CustomCardModel card)
    {
        //This will attempt to load SomniaCottonwood/images/cards/frame.png
        return PreloadManager.Cache.GetTexture2D("cards/frame.png".ImagePath());
    }*/

    //Color of small card icons
    public override Color DeckEntryCardColor => new("616d53");

    public override Color EnergyOutlineColor => new("1A6625");

    public override bool IsColorless => false;
}