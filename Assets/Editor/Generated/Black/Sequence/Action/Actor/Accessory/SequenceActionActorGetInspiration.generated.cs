using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorGetInspiration : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint inspirationId_;
		public bool checkProbability_;
		public bool checkDouble_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetInspiration();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetInspiration", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetInspiration.ObjectType, null, properties, 0, 768);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetInspiration", base.GetFieldProperties(), 560160653, -1972410973);
            return fieldProperties;
        }

		
    }
}