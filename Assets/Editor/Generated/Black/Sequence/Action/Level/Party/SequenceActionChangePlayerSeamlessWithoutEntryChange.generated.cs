using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Party
{
    public partial class SequenceActionChangePlayerSeamlessWithoutEntryChange : Black.Sequence.Action.Level.SequenceActionChangePlayer
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangePlayerSeamlessWithoutEntryChange();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSeamlessWithoutEntryChange", 0, Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSeamlessWithoutEntryChange.ObjectType, null, properties, 0, 464);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Party.SequenceActionChangePlayerSeamlessWithoutEntryChange", base.GetFieldProperties(), -39956255, -1750601999);
            
			
			
			return fieldProperties;
        }

		
    }
}