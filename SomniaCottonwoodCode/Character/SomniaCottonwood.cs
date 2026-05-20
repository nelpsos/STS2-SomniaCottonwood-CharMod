using BaseLib.Abstracts;
using BaseLib.Utils.NodeFactories;
using SomniaCottonwood.SomniaCottonwoodCode.Extensions;
using Godot;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.Relics;
using SomniaCottonwoodCode.Cards;

namespace SomniaCottonwood.SomniaCottonwoodCode.Character;

public class SomniaCottonwood : PlaceholderCharacterModel
{
    public const string CharacterId = "SomniaCottonwood";

    public static readonly Color Color = new("616d53");

    public override Color NameColor => Color;
    public override CharacterGender Gender => CharacterGender.Feminine;
    public override int StartingHp => 70;

    public override IEnumerable<CardModel> StartingDeck => [
        new StrikeSomniaCottonwood(),
        new StrikeSomniaCottonwood(),
        new StrikeSomniaCottonwood(),
        new StrikeSomniaCottonwood(),
        new StrikeSomniaCottonwood(),
        new StrikeSomniaCottonwood(),
        new DefendSomniaCottonwood(),
        new DefendSomniaCottonwood(),
        new DefendSomniaCottonwood(),
        new DefendSomniaCottonwood(),
        new DefendSomniaCottonwood()
    ];

    public override IReadOnlyList<RelicModel> StartingRelics =>
    [
        ModelDb.Relic<BurningBlood>()
    ];

    public override CardPoolModel CardPool => ModelDb.CardPool<SomniaCottonwoodCardPool>();
    public override RelicPoolModel RelicPool => ModelDb.RelicPool<SomniaCottonwoodRelicPool>();
    public override PotionPoolModel PotionPool => ModelDb.PotionPool<SomniaCottonwoodPotionPool>();

    /*  PlaceholderCharacterModel will utilize placeholder basegame assets for most of your character assets until you
        override all the other methods that define those assets. 
        These are just some of the simplest assets, given some placeholders to differentiate your character with. 
        You don't have to, but you're suggested to rename these images. */
    public override Control CustomIcon
    {
        get
        {
            var icon = NodeFactory<Control>.CreateFromResource(CustomIconTexturePath);
            icon.SetAnchorsAndOffsetsPreset(Control.LayoutPreset.FullRect);
            return icon;
        }
    }
    public override string CustomIconTexturePath => "character_icon_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectIconPath => "char_select_char_name.png".CharacterUiPath();
    public override string CustomCharacterSelectLockedIconPath => "char_select_char_name_locked.png".CharacterUiPath();
    public override string CustomMapMarkerPath => "map_marker_char_name.png".CharacterUiPath();
}