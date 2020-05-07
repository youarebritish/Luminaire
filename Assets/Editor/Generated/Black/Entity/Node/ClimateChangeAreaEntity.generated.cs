using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class ClimateChangeAreaEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enableTrigger_;
		public UnityEngine.Vector4 scaling_;
		public uint insideFixId_;
		public short exposureId_;
		public short postEffectId_;
		public short cameraLightId_;
		public short priorityLevel_;
		public float transitionTime_;
		public string memo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ClimateChangeAreaEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.ClimateChangeAreaEntity", 0, Black.Entity.Node.ClimateChangeAreaEntity.ObjectType, null, properties, 0, 320);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.ClimateChangeAreaEntity", base.GetFieldProperties(), 1001642552, 1716286985);
            return fieldProperties;
        }

		
    }
}