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
    public partial class DebugCampMenuItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_= string.Empty;
		[UnityEngine.SerializeReference] public List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList0_= new List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem>();
		[UnityEngine.SerializeReference] public List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList1_= new List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem>();
		[UnityEngine.SerializeReference] public List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem> campCameraItemList2_= new List<Black.Sequence.Action.Debug.DebugCampMenuCameraItem>();
		public string commentJP_= string.Empty;
		public string commentEng_= string.Empty;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DebugCampMenuItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.DebugCampMenuItem", 0, Black.Sequence.Action.Debug.DebugCampMenuItem.ObjectType, Construct, properties, 0, 104);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.DebugCampMenuItem", base.GetFieldProperties(), 1178279095, 858728601);
            
			
			
			fieldProperties.AddProperty(new Property("filePath_", 956091201, "Ebony.Base.String", 8, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("campCameraItemList0_", 203148833, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Debug.DebugCampMenuCameraItem* >", 24, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("campCameraItemList1_", 203295928, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Debug.DebugCampMenuCameraItem* >", 40, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("campCameraItemList2_", 3424642703, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Debug.DebugCampMenuCameraItem* >", 56, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("commentJP_", 4045859969, "Ebony.Base.String", 72, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("commentEng_", 2841836643, "Ebony.Base.String", 88, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new DebugCampMenuItem();
        }
		
    }
}