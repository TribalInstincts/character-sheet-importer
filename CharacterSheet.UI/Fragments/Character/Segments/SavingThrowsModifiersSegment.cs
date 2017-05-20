using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CharacterSheet.Pathfinder;
using CharacterSheet.UI.Views;

namespace CharacterSheet.UI.Fragments.Character.Segments
{
    public class SavingThrowsModifiersSegment : BaseCharacterSegement
    {
        private ScaledTextView _conditionalModifiers;

        public SavingThrowsModifiersSegment(Activity activity, ViewGroup root, CharacterStats selectedCharacter, CharacterFragment characterFragment) : base(activity, root, selectedCharacter, characterFragment)
        {
        }
        
        public override void AssignValues()
        {
            _conditionalModifiers.SetText(_selectedCharacter.SavingThrows.ConditionalSaveModifiers);
        }

        protected override void AssociateViews(ViewGroup root)
        {
            _conditionalModifiers = (ScaledTextView)root.FindViewById(Resource.Id.savingThrowsConditionalSaveModifiers);
        }
    }
}