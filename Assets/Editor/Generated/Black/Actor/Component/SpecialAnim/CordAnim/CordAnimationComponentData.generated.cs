using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.SpecialAnim.CordAnim
{
    public partial class CordAnimationComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> boneNames_;
		public float spring_;
		public float damping_;
		public float parentAngularDamping_;
		public float childAngularDamping_;
		public bool headRoot_;
		public bool twosideRoot_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new CordAnimationComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData", 0, Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData.ObjectType, null, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.SpecialAnim.CordAnim.CordAnimationComponentData", base.GetFieldProperties(), 1394393593, 1203659094);
            
			fieldProperties.AddProperty(new Property("boneNames_", 2097359126, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Utility.FixidArrayItem* >", 64, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("spring_", 2276694345, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("damping_", 3302352382, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("parentAngularDamping_", 2498377442, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("childAngularDamping_", 2758611074, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("headRoot_", 1282497984, "bool", 96, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("twosideRoot_", 2225786283, "bool", 97, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}