using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class SummonDirectionShapecastParameters : Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 halfLength_;
		public UnityEngine.Vector4 rotation_;
		public UnityEngine.Vector4 translation_;
		public float shapecastLength_;
		public float score_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SummonDirectionShapecastParameters();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.SummonDirectionShapecastParameters", 0, Black.Entity.Data.CharacterEntry.SummonDirectionShapecastParameters.ObjectType, null, properties, 0, 80);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.SummonDirectionShapecastParameters", base.GetFieldProperties(), -578458331, 1379660639);
            
			
			
			return fieldProperties;
        }

		
    }
}