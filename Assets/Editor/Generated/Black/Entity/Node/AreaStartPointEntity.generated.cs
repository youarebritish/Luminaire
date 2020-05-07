using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class AreaStartPointEntity : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string labelName_;
		public uint stayPlaceID_;
		public int valueType_;
		public int labelValue_;
		public float labelValueFloat_;
		public bool labelValueBool_;
		public string labelValueString_;
		public bool navimeshSeedPoint_;
		public bool isLoopDungeon_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AreaStartPointEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.AreaStartPointEntity", 0, Black.Entity.Node.AreaStartPointEntity.ObjectType, null, properties, 0, 336);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.AreaStartPointEntity", base.GetFieldProperties(), 867666509, 1639945546);
            return fieldProperties;
        }

		
    }
}