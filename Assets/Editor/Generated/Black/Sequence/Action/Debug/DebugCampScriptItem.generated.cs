//----------------------
// <auto-generated>
// This file was automatically generated. Any changes to it will be lost if and when the file is regenerated.
// </auto-generated>
//----------------------
#pragma warning disable

using System;
using SQEX.Luminous.Core.Object;
using System.Collections.Generic;
using CodeDom = System.CodeDom;

namespace Black.Sequence.Action.Debug
{
    [Serializable, CodeDom.Compiler.GeneratedCode("Luminaire", "0.1")]
    public partial class DebugCampScriptItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint sceneId_;
		public int cameraScene0Num_;
		public int cameraScene1Num_;
		public string commentJP_= string.Empty;
		public string commentEng_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DebugCampScriptItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.DebugCampScriptItem", 0, Black.Sequence.Action.Debug.DebugCampScriptItem.ObjectType, Construct, properties, 0, 56);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.DebugCampScriptItem", base.GetFieldProperties(), 593959274, -1807307266);
            
			
			
			fieldProperties.AddProperty(new Property("sceneId_", 2391626355, "SQEX.Ebony.Std.Fixid", 8, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraScene0Num_", 164384631, "int", 12, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraScene1Num_", 3289770972, "int", 16, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("commentJP_", 4045859969, "Ebony.Base.String", 24, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("commentEng_", 2841836643, "Ebony.Base.String", 40, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new DebugCampScriptItem();
        }
		
    }
}