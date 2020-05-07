using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionChangeBgmMode : Black.Sequence.Actor.SequenceActionBgmBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int mode_;
		public int bgmtype_mode_;
		public bool isWeakPlay_;
		public bool isPlayRecalcSlot_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeBgmMode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionChangeBgmMode", 0, Black.Sequence.Actor.SequenceActionChangeBgmMode.ObjectType, null, properties, 0, 400);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionChangeBgmMode", base.GetFieldProperties(), 1512717384, 335272794);
            return fieldProperties;
        }

		
    }
}