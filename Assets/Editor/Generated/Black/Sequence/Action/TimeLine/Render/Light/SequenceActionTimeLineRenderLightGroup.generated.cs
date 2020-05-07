using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render.Light
{
    public partial class SequenceActionTimeLineRenderLightGroup : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorGroupBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderLightGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightGroup", 0, Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightGroup.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.Light.SequenceActionTimeLineRenderLightGroup", base.GetFieldProperties(), -731531015, -773683700);
            return fieldProperties;
        }

		
    }
}