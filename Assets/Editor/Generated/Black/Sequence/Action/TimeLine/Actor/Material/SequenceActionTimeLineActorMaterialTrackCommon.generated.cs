using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Actor.Material
{
    public partial class SequenceActionTimeLineActorMaterialTrackCommon : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string materialName_;
		public string parameterName_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineActorMaterialTrackCommon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon", 0, Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon.ObjectType, null, properties, 0, 416);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Actor.Material.SequenceActionTimeLineActorMaterialTrackCommon", base.GetFieldProperties(), 1683437901, -1563059511);
            return fieldProperties;
        }

		
    }
}