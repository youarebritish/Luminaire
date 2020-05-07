using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Render
{
    public partial class SequenceActionTimeLineRenderGroup : SQEX.Ebony.Framework.Sequence.Action.SequenceActionTimeLineTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineRenderGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderGroup", 0, Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderGroup.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Render.SequenceActionTimeLineRenderGroup", base.GetFieldProperties(), 430764683, 1142783534);
            return fieldProperties;
        }

		
    }
}