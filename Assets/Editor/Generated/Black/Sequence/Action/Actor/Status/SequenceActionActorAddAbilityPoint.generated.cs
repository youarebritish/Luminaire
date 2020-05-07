using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorAddAbilityPoint : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int addAbilityPoint_;
		public bool drawMenu_;
		public bool drawMenu2_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin add_ap_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddAbilityPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorAddAbilityPoint", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorAddAbilityPoint.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorAddAbilityPoint", base.GetFieldProperties(), 1323102920, 107202559);
            return fieldProperties;
        }

		
    }
}