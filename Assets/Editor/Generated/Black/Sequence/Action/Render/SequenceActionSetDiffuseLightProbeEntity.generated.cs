using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Render
{
    public partial class SequenceActionSetDiffuseLightProbeEntity : Black.Sequence.Actor.SequenceActionEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetDiffuseLightProbeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Render.SequenceActionSetDiffuseLightProbeEntity", 0, Black.Sequence.Action.Render.SequenceActionSetDiffuseLightProbeEntity.ObjectType, null, properties, 0, 544);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Render.SequenceActionSetDiffuseLightProbeEntity", base.GetFieldProperties(), 1467366838, 698772414);
            return fieldProperties;
        }

		
    }
}