using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionChangeParty : Black.Sequence.Actor.SequenceActionPlayerStartBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool drawMenu_;
		public bool toReleasePartyOverride_;
		public bool joinToBattle_;
		public bool noRefreshParty_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeParty();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionChangeParty", 0, Black.Sequence.Actor.SequenceActionChangeParty.ObjectType, null, properties, 0, 904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionChangeParty", base.GetFieldProperties(), 1267161734, 1473227576);
            
			
			
			return fieldProperties;
        }

		
    }
}