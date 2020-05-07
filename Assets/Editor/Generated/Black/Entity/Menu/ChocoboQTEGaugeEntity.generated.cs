using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class ChocoboQTEGaugeEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public UnityEngine.Vector4 offset3d_;
		public uint button_;
		public uint message_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ChocoboQTEGaugeEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.ChocoboQTEGaugeEntity", 0, Black.Entity.Menu.ChocoboQTEGaugeEntity.ObjectType, null, properties, 0, 608);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.ChocoboQTEGaugeEntity", base.GetFieldProperties(), -1427649797, -1357233354);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("menuFixID_", 107051205, "SQEX.Ebony.Std.Fixid", 256, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("swfEntryPackagePath_", 3946372377, "Ebony.Base.String", 272, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			fieldProperties.AddProperty(new Property("offset3d_", 1591663190, "Luminous.Math.VectorA", 496, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("button_", 3219973226, "SQEX.Ebony.Std.Fixid", 512, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("message_", 3825450593, "SQEX.Ebony.Std.Fixid", 516, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}