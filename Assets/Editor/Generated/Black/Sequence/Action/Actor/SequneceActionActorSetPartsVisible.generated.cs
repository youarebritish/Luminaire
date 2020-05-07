using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequneceActionActorSetPartsVisible : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool meshPartsStatus_;
		public string visiblePartsName_;
		public string invisiblePartsName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequneceActionActorSetPartsVisible();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequneceActionActorSetPartsVisible", 0, Black.Sequence.Action.Actor.SequneceActionActorSetPartsVisible.ObjectType, null, properties, 0, 520);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequneceActionActorSetPartsVisible", base.GetFieldProperties(), -1199791192, 1742171645);
            return fieldProperties;
        }

		
    }
}