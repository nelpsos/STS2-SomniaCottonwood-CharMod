using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.ValueProps;
using BaseLib.Utils;
using SomniaCottonwood.SomniaCottonwoodCode.Cards;
using SomniaCottonwood.SomniaCottonwoodCode.Character;

namespace SomniaCottonwoodCode.Cards;

[Pool(typeof(SomniaCottonwoodCardPool))]
public class StrikeSomniaCottonwood() : SomniaCottonwoodCard(1, CardType.Attack, CardRarity.Basic, TargetType.AnyEnemy)
{
    protected override HashSet<CardTag> CanonicalTags => [CardTag.Strike];

    protected override IEnumerable<DynamicVar> CanonicalVars => [new DamageVar(6m, ValueProp.Move)];

    protected override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay play)
    {

    }


    protected override void OnUpgrade()
    {
        base.DynamicVars.Damage.UpgradeValueBy(3m);
    }
}