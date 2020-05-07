using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorCheckInspiration : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint inspirationId_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin target_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin indexOutput_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin pcOutput_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCheckInspiration();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckInspiration", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckInspiration.ObjectType, null, properties, 0, 760);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckInspiration", base.GetFieldProperties(), -80646258, 1990767591);
            return fieldProperties;
        }

		
    }
}